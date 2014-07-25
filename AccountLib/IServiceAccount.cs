using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AccountLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceAccount
    {
        [OperationContract]
        bool AddTransaction(string accountName, Transaction transaction);

        [OperationContract]
        bool CreateAccount(string accountName);

        [OperationContract]
        double GetBalance(string accountName);

        [OperationContract]
        List<Transaction> GetTransactions(string accountName);

        // TODO: Add your service operations here
    }
}
