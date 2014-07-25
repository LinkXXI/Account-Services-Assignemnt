namespace Account_Services
{
    partial class accountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbxActivity = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdGetBalance = new System.Windows.Forms.Button();
            this.cmdCreateAccount = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccountOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoWithdrawal = new System.Windows.Forms.RadioButton();
            this.rdoDeposit = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxActivity
            // 
            this.lstbxActivity.FormattingEnabled = true;
            this.lstbxActivity.Location = new System.Drawing.Point(6, 19);
            this.lstbxActivity.Name = "lstbxActivity";
            this.lstbxActivity.Size = new System.Drawing.Size(163, 212);
            this.lstbxActivity.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbxActivity);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Activity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdGetBalance);
            this.groupBox2.Controls.Add(this.cmdCreateAccount);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtAccountOwner);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // cmdGetBalance
            // 
            this.cmdGetBalance.Location = new System.Drawing.Point(233, 76);
            this.cmdGetBalance.Name = "cmdGetBalance";
            this.cmdGetBalance.Size = new System.Drawing.Size(101, 23);
            this.cmdGetBalance.TabIndex = 5;
            this.cmdGetBalance.Text = "Get Balance";
            this.cmdGetBalance.UseVisualStyleBackColor = true;
            this.cmdGetBalance.Click += new System.EventHandler(this.cmdGetBalance_Click);
            // 
            // cmdCreateAccount
            // 
            this.cmdCreateAccount.Location = new System.Drawing.Point(12, 76);
            this.cmdCreateAccount.Name = "cmdCreateAccount";
            this.cmdCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.cmdCreateAccount.TabIndex = 4;
            this.cmdCreateAccount.Text = "Create Account";
            this.cmdCreateAccount.UseVisualStyleBackColor = true;
            this.cmdCreateAccount.Click += new System.EventHandler(this.cmdCreateAccount_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(101, 48);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(135, 20);
            this.txtBalance.TabIndex = 3;
            // 
            // txtAccountOwner
            // 
            this.txtAccountOwner.Location = new System.Drawing.Point(101, 15);
            this.txtAccountOwner.Name = "txtAccountOwner";
            this.txtAccountOwner.Size = new System.Drawing.Size(135, 20);
            this.txtAccountOwner.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Owner";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTransaction);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(13, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 125);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(175, 96);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(159, 23);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Submit Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(175, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoWithdrawal);
            this.groupBox4.Controls.Add(this.rdoDeposit);
            this.groupBox4.Location = new System.Drawing.Point(6, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 73);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type";
            // 
            // rdoWithdrawal
            // 
            this.rdoWithdrawal.AutoSize = true;
            this.rdoWithdrawal.Location = new System.Drawing.Point(6, 42);
            this.rdoWithdrawal.Name = "rdoWithdrawal";
            this.rdoWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.rdoWithdrawal.TabIndex = 1;
            this.rdoWithdrawal.Text = "Withdrawal";
            this.rdoWithdrawal.UseVisualStyleBackColor = true;
            this.rdoWithdrawal.CheckedChanged += new System.EventHandler(this.rdoWithdrawal_CheckedChanged);
            // 
            // rdoDeposit
            // 
            this.rdoDeposit.AutoSize = true;
            this.rdoDeposit.Checked = true;
            this.rdoDeposit.Location = new System.Drawing.Point(6, 19);
            this.rdoDeposit.Name = "rdoDeposit";
            this.rdoDeposit.Size = new System.Drawing.Size(61, 17);
            this.rdoDeposit.TabIndex = 0;
            this.rdoDeposit.TabStop = true;
            this.rdoDeposit.Text = "Deposit";
            this.rdoDeposit.UseVisualStyleBackColor = true;
            this.rdoDeposit.CheckedChanged += new System.EventHandler(this.rdoDeposit_CheckedChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 254);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(550, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 276);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 315);
            this.MinimumSize = new System.Drawing.Size(566, 315);
            this.Name = "accountForm";
            this.Text = "Account Client";
            this.Load += new System.EventHandler(this.accountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxActivity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdGetBalance;
        private System.Windows.Forms.Button cmdCreateAccount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoWithdrawal;
        private System.Windows.Forms.RadioButton rdoDeposit;
        private System.Windows.Forms.StatusStrip status;
    }
}

