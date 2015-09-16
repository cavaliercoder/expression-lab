namespace System.Drawing
{
    using System.Xml.Serialization;

    public class SystemColorScheme : ColorScheme
    {
        #region System Colors

        public Color ActiveBorder
        {
            get
            {
                if (!this.ContainsKey("ActiveBorder"))
                    return SystemColors.ActiveBorder;

                return this["ActiveBorder"];
            }

            set
            {
                if (this.ContainsKey("ActiveBorder"))
                    this["ActiveBorder"] = value;
                else
                    this.Add("ActiveBorder", value);
            }
        }

        public Color ActiveCaption
        {
            get
            {
                if (!this.ContainsKey("ActiveCaption"))
                    return SystemColors.ActiveCaption;

                return this["ActiveCaption"];
            }

            set
            {
                if (this.ContainsKey("ActiveCaption"))
                    this["ActiveCaption"] = value;
                else
                    this.Add("ActiveCaption", value);
            }
        }

        public Color ActiveCaptionText
        {
            get
            {
                if (!this.ContainsKey("ActiveCaptionText"))
                    return SystemColors.ActiveCaptionText;

                return this["ActiveCaptionText"];
            }

            set
            {
                if (this.ContainsKey("ActiveCaptionText"))
                    this["ActiveCaptionText"] = value;
                else
                    this.Add("ActiveCaptionText", value);
            }
        }

        public Color AppWorkspace
        {
            get
            {
                if (!this.ContainsKey("AppWorkspace"))
                    return SystemColors.AppWorkspace;

                return this["AppWorkspace"];
            }

            set
            {
                if (this.ContainsKey("AppWorkspace"))
                    this["AppWorkspace"] = value;
                else
                    this.Add("AppWorkspace", value);
            }
        }

        public Color ButtonFace
        {
            get
            {
                if (!this.ContainsKey("ButtonFace"))
                    return SystemColors.ButtonFace;

                return this["ButtonFace"];
            }

            set
            {
                if (this.ContainsKey("ButtonFace"))
                    this["ButtonFace"] = value;
                else
                    this.Add("ButtonFace", value);
            }
        }

        
        public Color ButtonHighlight
        {
            get
            {
                if (!this.ContainsKey("ButtonHighlight"))
                    return SystemColors.ButtonHighlight;

                return this["ButtonHighlight"];
            }

            set
            {
                if (this.ContainsKey("ButtonHighlight"))
                    this["ButtonHighlight"] = value;
                else
                    this.Add("ButtonHighlight", value);
            }
        }

        
        public Color ButtonShadow
        {
            get
            {
                if (!this.ContainsKey("ButtonShadow"))
                    return SystemColors.ButtonShadow;

                return this["ButtonShadow"];
            }

            set
            {
                if (this.ContainsKey("ButtonShadow"))
                    this["ButtonShadow"] = value;
                else
                    this.Add("ButtonShadow", value);
            }
        }

        
        public Color Control
        {
            get
            {
                if (!this.ContainsKey("Control"))
                    return SystemColors.Control;

                return this["Control"];
            }

            set
            {
                if (this.ContainsKey("Control"))
                    this["Control"] = value;
                else
                    this.Add("Control", value);
            }
        }

        
        public Color ControlDark
        {
            get
            {
                if (!this.ContainsKey("ControlDark"))
                    return SystemColors.ControlDark;

                return this["ControlDark"];
            }

            set
            {
                if (this.ContainsKey("ControlDark"))
                    this["ControlDark"] = value;
                else
                    this.Add("ControlDark", value);
            }
        }

        
        public Color ControlDarkDark
        {
            get
            {
                if (!this.ContainsKey("ControlDarkDark"))
                    return SystemColors.ControlDarkDark;

                return this["ControlDarkDark"];
            }

            set
            {
                if (this.ContainsKey("ControlDarkDark"))
                    this["ControlDarkDark"] = value;
                else
                    this.Add("ControlDarkDark", value);
            }
        }

        
        public Color ControlLight
        {
            get
            {
                if (!this.ContainsKey("ControlLight"))
                    return SystemColors.ControlLight;

                return this["ControlLight"];
            }

            set
            {
                if (this.ContainsKey("ControlLight"))
                    this["ControlLight"] = value;
                else
                    this.Add("ControlLight", value);
            }
        }

        
        public Color ControlLightLight
        {
            get
            {
                if (!this.ContainsKey("ControlLightLight"))
                    return SystemColors.ControlLightLight;

                return this["ControlLightLight"];
            }

            set
            {
                if (this.ContainsKey("ControlLightLight"))
                    this["ControlLightLight"] = value;
                else
                    this.Add("ControlLightLight", value);
            }
        }

        
        public Color ControlText
        {
            get
            {
                if (!this.ContainsKey("ControlText"))
                    return SystemColors.ControlText;

                return this["ControlText"];
            }

            set
            {
                if (this.ContainsKey("ControlText"))
                    this["ControlText"] = value;
                else
                    this.Add("ControlText", value);
            }
        }

        
        public Color Desktop
        {
            get
            {
                if (!this.ContainsKey("Desktop"))
                    return SystemColors.Desktop;

                return this["Desktop"];
            }

            set
            {
                if (this.ContainsKey("Desktop"))
                    this["Desktop"] = value;
                else
                    this.Add("Desktop", value);
            }
        }

        
        public Color GradientActiveCaption
        {
            get
            {
                if (!this.ContainsKey("GradientActiveCaption"))
                    return SystemColors.GradientActiveCaption;

                return this["GradientActiveCaption"];
            }

            set
            {
                if (this.ContainsKey("GradientActiveCaption"))
                    this["GradientActiveCaption"] = value;
                else
                    this.Add("GradientActiveCaption", value);
            }
        }

        
        public Color GradientInactiveCaption
        {
            get
            {
                if (!this.ContainsKey("GradientInactiveCaption"))
                    return SystemColors.GradientInactiveCaption;

                return this["GradientInactiveCaption"];
            }

            set
            {
                if (this.ContainsKey("GradientInactiveCaption"))
                    this["GradientInactiveCaption"] = value;
                else
                    this.Add("GradientInactiveCaption", value);
            }
        }

        
        public Color GrayText
        {
            get
            {
                if (!this.ContainsKey("GrayText"))
                    return SystemColors.GrayText;

                return this["GrayText"];
            }

            set
            {
                if (this.ContainsKey("GrayText"))
                    this["GrayText"] = value;
                else
                    this.Add("GrayText", value);
            }
        }

        
        public Color Highlight
        {
            get
            {
                if (!this.ContainsKey("Highlight"))
                    return SystemColors.Highlight;

                return this["Highlight"];
            }

            set
            {
                if (this.ContainsKey("Highlight"))
                    this["Highlight"] = value;
                else
                    this.Add("Highlight", value);
            }
        }

        
        public Color HighlightText
        {
            get
            {
                if (!this.ContainsKey("HighlightText"))
                    return SystemColors.HighlightText;

                return this["HighlightText"];
            }

            set
            {
                if (this.ContainsKey("HighlightText"))
                    this["HighlightText"] = value;
                else
                    this.Add("HighlightText", value);
            }
        }

        
        public Color HotTrack
        {
            get
            {
                if (!this.ContainsKey("HotTrack"))
                    return SystemColors.HotTrack;

                return this["HotTrack"];
            }

            set
            {
                if (this.ContainsKey("HotTrack"))
                    this["HotTrack"] = value;
                else
                    this.Add("HotTrack", value);
            }
        }

        
        public Color InactiveBorder
        {
            get
            {
                if (!this.ContainsKey("InactiveBorder"))
                    return SystemColors.InactiveBorder;

                return this["InactiveBorder"];
            }

            set
            {
                if (this.ContainsKey("InactiveBorder"))
                    this["InactiveBorder"] = value;
                else
                    this.Add("InactiveBorder", value);
            }
        }

        
        public Color InactiveCaption
        {
            get
            {
                if (!this.ContainsKey("InactiveCaption"))
                    return SystemColors.InactiveCaption;

                return this["InactiveCaption"];
            }

            set
            {
                if (this.ContainsKey("InactiveCaption"))
                    this["InactiveCaption"] = value;
                else
                    this.Add("InactiveCaption", value);
            }
        }

        
        public Color InactiveCaptionText
        {
            get
            {
                if (!this.ContainsKey("InactiveCaptionText"))
                    return SystemColors.InactiveCaptionText;

                return this["InactiveCaptionText"];
            }

            set
            {
                if (this.ContainsKey("InactiveCaptionText"))
                    this["InactiveCaptionText"] = value;
                else
                    this.Add("InactiveCaptionText", value);
            }
        }

        
        public Color Info
        {
            get
            {
                if (!this.ContainsKey("Info"))
                    return SystemColors.Info;

                return this["Info"];
            }

            set
            {
                if (this.ContainsKey("Info"))
                    this["Info"] = value;
                else
                    this.Add("Info", value);
            }
        }

        
        public Color InfoText
        {
            get
            {
                if (!this.ContainsKey("InfoText"))
                    return SystemColors.InfoText;

                return this["InfoText"];
            }

            set
            {
                if (this.ContainsKey("InfoText"))
                    this["InfoText"] = value;
                else
                    this.Add("InfoText", value);
            }
        }

        
        public Color Menu
        {
            get
            {
                if (!this.ContainsKey("Menu"))
                    return SystemColors.Menu;

                return this["Menu"];
            }

            set
            {
                if (this.ContainsKey("Menu"))
                    this["Menu"] = value;
                else
                    this.Add("Menu", value);
            }
        }

        
        public Color MenuBar
        {
            get
            {
                if (!this.ContainsKey("MenuBar"))
                    return SystemColors.MenuBar;

                return this["MenuBar"];
            }

            set
            {
                if (this.ContainsKey("MenuBar"))
                    this["MenuBar"] = value;
                else
                    this.Add("MenuBar", value);
            }
        }

        
        public Color MenuHighlight
        {
            get
            {
                if (!this.ContainsKey("MenuHighlight"))
                    return SystemColors.MenuHighlight;

                return this["MenuHighlight"];
            }

            set
            {
                if (this.ContainsKey("MenuHighlight"))
                    this["MenuHighlight"] = value;
                else
                    this.Add("MenuHighlight", value);
            }
        }

        
        public Color MenuText
        {
            get
            {
                if (!this.ContainsKey("MenuText"))
                    return SystemColors.MenuText;

                return this["MenuText"];
            }

            set
            {
                if (this.ContainsKey("MenuText"))
                    this["MenuText"] = value;
                else
                    this.Add("MenuText", value);
            }
        }

        
        public Color ScrollBar
        {
            get
            {
                if (!this.ContainsKey("ScrollBar"))
                    return SystemColors.ScrollBar;

                return this["ScrollBar"];
            }

            set
            {
                if (this.ContainsKey("ScrollBar"))
                    this["ScrollBar"] = value;
                else
                    this.Add("ScrollBar", value);
            }
        }

        
        public Color Window
        {
            get
            {
                if (!this.ContainsKey("Window"))
                    return SystemColors.Window;

                return this["Window"];
            }

            set
            {
                if (this.ContainsKey("Window"))
                    this["Window"] = value;
                else
                    this.Add("Window", value);
            }
        }

        
        public Color WindowFrame
        {
            get
            {
                if (!this.ContainsKey("WindowFrame"))
                    return SystemColors.WindowFrame;

                return this["WindowFrame"];
            }

            set
            {
                if (this.ContainsKey("WindowFrame"))
                    this["WindowFrame"] = value;
                else
                    this.Add("WindowFrame", value);
            }
        }

        
        public Color WindowText
        {
            get
            {
                if (!this.ContainsKey("WindowText"))
                    return SystemColors.WindowText;

                return this["WindowText"];
            }

            set
            {
                if (this.ContainsKey("WindowText"))
                    this["WindowText"] = value;
                else
                    this.Add("WindowText", value);
            }
        }

        #endregion
    }
}
