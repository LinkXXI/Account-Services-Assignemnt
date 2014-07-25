using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AccountLib
{   
    [DataContract]
    public enum TransactionType
    {
        [EnumMember]
        WITHDRAW,
        [EnumMember]
        DEPOSIT
    }
}
