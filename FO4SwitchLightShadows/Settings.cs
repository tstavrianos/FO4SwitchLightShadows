using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FO4SwitchLightShadows
{
    public enum RunMode
    {
        RemoveShadows,
        AddShadows
    }
    public class Settings
    {
        [MaintainOrder] [SettingName("Run Mode")]
        public RunMode Mode { get; set; } = RunMode.RemoveShadows;
    }
}