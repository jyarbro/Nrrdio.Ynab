using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum ClearedState {
        [EnumMember(Value = "cleared")]
        Cleared,

        [EnumMember(Value = "uncleared")]
        Uncleared,

        [EnumMember(Value = "reconciled")]
        Reconciled
    }
}
