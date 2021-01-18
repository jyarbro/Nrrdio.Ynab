using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum TransactionType {
        [EnumMember(Value = "transaction")]
        Transaction,

        [EnumMember(Value = "subtransaction")]
        SubTransaction
    }
}
