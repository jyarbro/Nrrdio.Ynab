using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Models.Accounts {
    public enum AccountType {
        [EnumMember(Value = "checking")]
        Checking,

        [EnumMember(Value = "savings")]
        Savings,

        [EnumMember(Value = "cash")]
        Cash,

        [EnumMember(Value = "creditCard")]
        CreditCard,

        [EnumMember(Value = "lineOfCredit")]
        LineOfCredit,

        [EnumMember(Value = "otherAsset")]
        OtherAsset,

        [EnumMember(Value = "otherLiability")]
        OtherLiability
    }
}
