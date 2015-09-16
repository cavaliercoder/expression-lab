namespace System.Text.RegularExpressions
{
    using System.Collections.Generic;

    public class Pattern
    {
        #region Constructors

        public Pattern(string pattern)
        {
            _pattern = pattern;
            analyze();
        }

        public static Pattern FromString(string pattern)
        {
            return new Pattern(pattern);
        }

        #endregion

        #region Fields

        private string _pattern;

        private ICollection<PatternElement> _elements;

        #endregion

        #region Properties

        public ICollection<PatternElement> Elements
        {
            get { return _elements; }
        }

        #endregion

        #region Methods

        private void analyze()
        {
            _elements = new List<PatternElement>();

            char c;
            bool escaped = false;
            bool inCommentLine = false;
            PatternComment commentLine = null;
            bool inCommentGroup = false;
            bool inCharClass = false;
            int groupDepth = -1;
            var groupStack = new List<PatternGroup>();

            for (int i = 0; i < _pattern.Length; i++)
            {
                if (!escaped)
                {
                    c = _pattern[i];

                    switch (c)
                    {
                        case '(':
                            if (!inCharClass)
                            {
                                groupDepth++;

                                var group = new PatternGroup { StartIndex = i };
                                switch (_pattern.Substring(i + 1, 2))
                                {
                                    case "?<":
                                        group.Type = PatterGroupType.NamedCapture;
                                        break;

                                    case"?:":
                                        group.Type = PatterGroupType.Noncapture;
                                        break;

                                    case "?>":
                                        group.Type = PatterGroupType.Atomic;
                                        break;

                                    case "?=":
                                    case "?!":
                                        group.Type = PatterGroupType.LookAround;
                                        break;

                                    case "?#":
                                        group.Type = PatterGroupType.Comment;
                                        inCommentGroup = true;
                                        break;
                                }

                                groupStack.Add(group);
                                _elements.Add(group);
                            }
                            break;

                        case ')':
                            if (!inCharClass && !inCommentLine)
                            {
                                groupStack[groupDepth].EndIndex = i;
                                groupDepth--;
                            }

                            break;

                        case '#':
                            if (!inCharClass)
                            {
                                inCommentLine = true;
                                commentLine = new PatternComment { StartIndex = i };
                                _elements.Add(commentLine);
                            }
                            break;

                        case '\n':
                            if (inCommentLine)
                            {
                                inCommentLine = false;
                                commentLine.EndIndex = i;
                            }
                            break;
                    }
                }
                else
                {
                    escaped = false;
                }
            }

            if (inCommentLine)
            {
                inCommentLine = false;
                commentLine.EndIndex = _pattern.Length - 1;
            }
        }

        private string GetNext(int index, int length)
        {
            if (_pattern.Length >= index + length)
            {
                return _pattern.Substring(index, length);
            }

            return String.Empty;
        }

        #endregion
    }
}
