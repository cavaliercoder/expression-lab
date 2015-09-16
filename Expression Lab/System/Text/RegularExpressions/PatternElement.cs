namespace System.Text.RegularExpressions
{
    public abstract class PatternElement
    {
        public int StartIndex { get; set; }

        public int EndIndex { get; set; }

        public string Contents { get; set; }
    }
}
