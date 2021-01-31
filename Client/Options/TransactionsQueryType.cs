using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum TransactionsQueryType {
        [EnumMember(Value = "uncategorized")]
        Uncategorized,

        [EnumMember(Value = "unapproved")]
        Unapproved
    }
}
