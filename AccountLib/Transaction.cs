using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AccountLib
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public TransactionType TransType { get; set; }
        [DataMember]
        public double Amount { get; set; }
    }
}
