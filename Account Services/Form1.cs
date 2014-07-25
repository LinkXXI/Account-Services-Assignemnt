using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Account_Services.AccountSvcReference;
using System.ServiceModel;

namespace Account_Services
{
    public partial class accountForm : Form
    {
        private ServiceAccountClient proxy = new ServiceAccountClient();
        private TransactionType transactionType = TransactionType.DEPOSIT;

        public accountForm()
        {
            InitializeComponent();
        }

        private void accountForm_Load(object sender, EventArgs e)
        {
            proxy.Open();
            txtAmount.ContextMenu = new ContextMenu();
            txtAmount.KeyPress += new KeyPressEventHandler(txtAmount_KeyPress);
        }

        void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (((TextBox)sender).Text.Length == 0 && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && ((TextBox)sender).Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    if (e.KeyChar != '.' )
                    {
                        e.Handled = true;
                    }
                    if (((TextBox)sender).Text.IndexOf('.') != -1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void cmdCreateAccount_Click(object sender, EventArgs e)
        {
            if (nameValid())
            {
                try
                {
                    if (proxy.CreateAccount(txtAccountOwner.Text))
                    {
                        status.Items.Clear();
                        status.Items.Add("Account For " + txtAccountOwner.Text + " has been created!");
                        getData();
                    }
                    else
                    {
                        status.Items.Clear();
                        status.Items.Add("Account creation failed");
                    }
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message, "Service Fault");
                    status.Items.Clear();
                    status.Items.Add(ex.Message);
                }
            }
        }

        private void cmdGetBalance_Click(object sender, EventArgs e)
        {
            getData();
            status.Items.Clear();
            status.Items.Add("Balance retrieved");
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (nameValid())
            {
                if (txtAmount.Text.Length == 0)
                {
                    MessageBox.Show("You must enter an ammount for a transaction!", "Application Error");
                }

                Transaction transaction = new Transaction();
                transaction.Amount = Convert.ToDouble(txtAmount.Text);
                transaction.TransType = transactionType;
                try
                {
                    proxy.AddTransaction(txtAccountOwner.Text, transaction);
                    status.Items.Clear();
                    status.Items.Add((transactionType == TransactionType.DEPOSIT) ? "Deposit " : "Withrdaw " + "Of $" + txtAmount.Text + " added");
                    getData();
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message, "Service Fault");
                }
            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            transactionType = TransactionType.DEPOSIT;
            status.Items.Clear();
            status.Items.Add("Transaction type changed to Deposit");
        }

        private void rdoWithdrawal_CheckedChanged(object sender, EventArgs e)
        {
            transactionType = TransactionType.WITHDRAW;
            status.Items.Clear();
            status.Items.Add("Transaction type changed to Withdraw");
        }

        private bool nameValid()
        {
            if (txtAccountOwner.Text.Length == 0)
            {
                MessageBox.Show("Account owner cannot be empty!", "Application Error");
                return false;
            }
            return true;
        }

        private void getData()
        {
            if (nameValid())
            {
                try
                {
                    txtBalance.Text = String.Format("{0:c}", proxy.GetBalance(txtAccountOwner.Text));
                    lstbxActivity.Items.Clear();
                    Transaction[] transList = proxy.GetTransactions(txtAccountOwner.Text);
                    for (int i = 0; i < transList.Count(); i++)
                    {
                        if (transList[i].TransType == TransactionType.DEPOSIT)
                        {
                            lstbxActivity.Items.Add(i + 1 + ": Deposited $" + transList[i].Amount);
                        }
                        else if (transList[i].TransType == TransactionType.WITHDRAW)
                        {
                            lstbxActivity.Items.Add(i + 1 + ": Withdrew $" + transList[i].Amount);
                        }
                    }
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message, "Service Fault");
                }
            }
        }
    }
}
