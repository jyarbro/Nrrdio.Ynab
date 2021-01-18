using System.Runtime.Serialization;

namespace Nrrdio.Ynab.Client.Options {
    public enum FlagColor {
        [EnumMember(Value = "red")]
        Red,

        [EnumMember(Value = "orange")]
        Orange,

        [EnumMember(Value = "yellow")]
        Yellow,

        [EnumMember(Value = "green")]
        Green,

        [EnumMember(Value = "blue")]
        Blue,

        [EnumMember(Value = "purple")]
        Purple
    }
}
