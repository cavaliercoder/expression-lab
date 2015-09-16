using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Regex_Tool
{
    public class ProjectColorScheme : ColorScheme
    {
        public ProjectColorScheme()
        {
            this.Add("WindowBackColor", SystemColors.Window);
            this.Add("WindowForeColor", SystemColors.WindowText);

            this.Add("HighlightForeColor", SystemColors.HighlightText);
            this.Add("HighlightBackColor", SystemColors.Highlight);

            this.Add("MatchBackColor", SystemColors.Window);
            this.Add("MatchForeColor", SystemColors.WindowText);

            this.Add("Grid", SystemColors.ControlLight);

            this.AddMatchScheme(Color.FromArgb(255,190,136), Color.Black);
            this.AddMatchScheme(Color.FromArgb(124,233,233), Color.Black);
            this.AddMatchScheme(Color.FromArgb(130,244,130), Color.Black);
            this.AddMatchScheme(Color.FromArgb(255, 136, 136), Color.Black);
            this.AddMatchScheme(Color.FromArgb(255, 253, 136), Color.Black);
            this.AddMatchScheme(Color.FromArgb(195,133,237), Color.Black);
            this.AddMatchScheme(Color.FromArgb(139,160,237), Color.Black);
        }

        private MatchColorScheme[] _matchColorSchemeCache;

        public void AddMatchScheme(Color backColor, Color foreColor)
        {
            var schemes = MatchColorSchemes;

            this.Add(String.Format("_MatchForeColor{0}", schemes.Length), foreColor);
            this.Add(String.Format("_MatchBackColor{0}", schemes.Length), backColor);
            this._matchColorSchemeCache = null;
        }

        public MatchColorScheme[] MatchColorSchemes
        {
            get
            {
                if(this._matchColorSchemeCache == null)
                {
                    var schemes = new List<MatchColorScheme>();
                    foreach (var key in this.Keys)
                    {
                        Match match = key.Match(@"_MatchForeColor([\d+])");
                        if (match.Success)
                        {
                            var backColorIndex = String.Format("_MatchBackColor{0}", match.Groups[1].Value);
                            var scheme = new MatchColorScheme(this[key], this[backColorIndex]);
                            schemes.Add(scheme);
                        }
                    }

                    _matchColorSchemeCache = schemes.ToArray();
                }

                return _matchColorSchemeCache;
            }
        }

        public Color WindowBackColor
        {
            get { return this["WindowBackColor"]; }
            set { this["WindowBackColor"] = value; }
        }

        public Color WindowForeColor
        {
            get { return this["WindowForeColor"]; }
            set { this["WindowForeColor"] = value; }
        }

        public Color Grid
        {
            get { return this["Grid"]; }
            set { this["Grid"] = value; }
        }

        public Color HighlightForeColor
        {
            get { return this["HighlightForeColor"]; }

            set { this["HighlightForeColor"] = value; }
        }

        public Color HighlightBackColor
        {
            get { return this["HighlightBackColor"]; }

            set { this["HighlightBackColor"] = value; }
        }

        public Color MatchForeColor
        {
            get { return this["MatchForeColor"]; }

            set { this["MatchForeColor"] = value; }
        }

        public Color MatchBackColor
        {
            get { return this["MatchBackColor"]; }

            set { this["MatchBackColor"] = value; }
        }

        public class MatchColorScheme
        {
            public MatchColorScheme(Color foreColor, Color backColor)
            {
                this.BackColor = backColor;
                this.ForeColor = ForeColor;
            }

            public Color ForeColor { get; set; }

            public Color BackColor { get; set; }
       
        }
    }
}
