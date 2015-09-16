namespace System.Text.RegularExpressions
{
    using System.Collections.Generic;

    public class PatternGroup : PatternElement
    {
        public bool IsNamed { get; set; }

        public string Name { get; set; }

        public PatterGroupType Type { get; set; }

        public ICollection<PatternGroup> SubGroups { get; set; }
    }

    public enum PatterGroupType
    {
        Capture,
        NamedCapture,
        Noncapture,
        Modifier,
        LookAround,
        Atomic,
        Comment
    }
}
