using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum GoalType {
        [EnumMember(Value = "TB")]
        TargetBalance,

        [EnumMember(Value = "TBD")]
        TargetBalanceByDate,

        [EnumMember(Value = "MF")]
        MonthlySavingsBuilder,

        [EnumMember(Value = "NEED")]
        NeededForSpending
    }
}
