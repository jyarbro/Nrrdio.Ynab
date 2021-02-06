using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum TransactionCategorizedApproved {
        [EnumMember(Value = "uncategorized")]
        Uncategorized,

        [EnumMember(Value = "unapproved")]
        Unapproved
    }
}
