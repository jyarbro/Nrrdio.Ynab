using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum Frequency {
        [EnumMember(Value = "never")]
        Never,

        [EnumMember(Value = "daily")]
        Daily,

        [EnumMember(Value = "weekly")]
        Weekly,

        [EnumMember(Value = "everyOtherWeek")]
        EveryOtherWeek,

        [EnumMember(Value = "twiceAMonth")]
        TwiceAMonth,

        [EnumMember(Value = "every4Weeks")]
        Every4Weeks,

        [EnumMember(Value = "monthly")]
        Monthly,

        [EnumMember(Value = "everyOtherMonth")]
        EveryOtherMonth,

        [EnumMember(Value = "every3Months")]
        Every3Months,

        [EnumMember(Value = "every4Months")]
        Every4Months,

        [EnumMember(Value = "twiceAYear")]
        TwiceAYear,

        [EnumMember(Value = "yearly")]
        Yearly,

        [EnumMember(Value = "everyOtherYear")]
        EveryOtherYear
    }
}
