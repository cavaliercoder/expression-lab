namespace Regex_Tool
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using DigitalRune.Windows.TextEditor;
    using Regex_Tool.Properties;
    using DigitalRune.Windows.TextEditor.Highlighting;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Hook events
            txtInput.Document.DocumentChanged += new EventHandler<DigitalRune.Windows.TextEditor.Document.DocumentEventArgs>(RegexDataChanged);
            txtPattern.Document.DocumentChanged += new EventHandler<DigitalRune.Windows.TextEditor.Document.DocumentEventArgs>(RegexDataChanged);

            // Default Cut/Paste operations to data box
            _activeControl = txtInput;

            // Pull up defaults
            _colors = new ProjectColorScheme();
            LoadInitSettings();
        }

        #region Fields

        private Project _project;

        private MatchCollection _matches;

        private const int _highlightingLimit = 1000;

        private int _highlightCount = 0;

        private List<ListViewItem> _listViewItems = new List<ListViewItem>();

        bool _suspendUi;

        bool _suspendRegex;

        string[] _groupNames;

        private TextEditorControl _activeControl;

        private ProjectColorScheme _colors = new ProjectColorScheme();

        private const TextFormatFlags _textFormatFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.WordEllipsis | TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;

        #endregion

        #region Regex

        private void RegexDataChanged()
        {
            if (_suspendRegex)
                return;

            // Update Project data
            _project.Pattern = txtPattern.Text;
            if(_project.FilterMode == FilterMode.None)
                _project.InputData = txtInput.Text;

            // Get results
            RefreshRegexResults();
        }

        private void RefreshRegexResults()
        {
            // Check if processing is paused
            if (_project.Paused)
            {
                ShowWarningStatus("Processing is paused. Resume processing to refresh results.");
                return;
            }

            // Prevent nested stack
            if (_suspendRegex) return;
                _suspendRegex = _suspendUi = true;

            Regex regex;
            bool error = false;
            _matches = null;
            _groupNames = null;

            // Don't bother matching on null patterns
            if (_project.Pattern.Length > 0)
            {
                //ParsePattern();
             
                try
                {

                    regex = new Regex(_project.Pattern, _project.RegexOptions);
                    _matches = regex.Matches(_project.InputData);
                    _groupNames = regex.GetGroupNames();
                }

                catch (ArgumentException x)
                {
                    // Cut pattern from error message
                    var match = x.Message.Match(
                        @"(parsing\s"".*""\s-\s(?<Error>.*))|(?<Error>.*)",
                        RegexOptions.Multiline
                        );

                    // remove line breaks
                    var msg = match.Groups["Error"].Value.Replace("\r\n", " ");
                    
                    // Show errors in status bar
                    ShowWarningStatus(msg);
                    error = true;
                }
            }

            // TODO: Select all groups for display
            _project.HighlightGroups.Clear();
            if(_groupNames != null)
                _project.HighlightGroups.AddRange(_groupNames);

            // Show status
            if(!error)
                ShowRegexStatus(_matches, _groupNames);

            _suspendRegex = _suspendUi = false;

            // Render results in the UI
            ShowRegexResults();
        }

        private void ParsePattern()
        {
            // TODO:
            var pattern = Pattern.FromString(_project.Pattern);
            int groupDepth = 0;
            foreach (var element in pattern.Elements)
            {
                System.Diagnostics.Debug.WriteLine(String.Format("{0} - {1} {2}", element.StartIndex, element.EndIndex, element.GetType().Name));

                if (element.GetType() == typeof(PatternGroup))
                {
                    var group = (PatternGroup) element;
                    switch (group.Type)
                    {
                        case PatterGroupType.Capture:
                            groupDepth++;
                            int colorIndex = groupDepth % _colors.MatchColorSchemes.Length;
                            
                            // Color Openning bracket
                            ColorPatternText(
                                element.StartIndex,
                                1,
                                _colors.MatchColorSchemes[colorIndex].BackColor
                                );

                            // Color closing bracket
                            ColorPatternText(
                                element.EndIndex,
                                1,
                                _colors.MatchColorSchemes[colorIndex].BackColor
                                );
                            break;
                    }
                }

                else if (element.GetType() == typeof(PatternComment))
                {
                    ColorPatternText(element.StartIndex, element.EndIndex, Color.Green);
                }
            }
        }

        #endregion

        #region Result Rendering

        private void ShowRegexResults()
        {
            // Prevent cascade
            _suspendUi = true;

            // Cleanup UI
            this.txtInput.Document.MarkerStrategy.Clear();
            this._listViewItems.Clear();

            if (_matches != null)
            {
                switch (_project.HighlightMode)
                {
                    case HighlightMode.None:
                    case HighlightMode.Matches:
                        ShowRegexResults_ByMatch();
                        break;

                    case HighlightMode.UnnamedGroups:
                    case HighlightMode.NamedGroups:
                    case HighlightMode.CustomGroups:
                        ShowRegexResults_ByGroups();
                        break;
                }
            }

            ApplyFilter();

            // Prevent popin
            txtInput.Refresh();

            // Update Listview
            this.listView1.VirtualListSize = _listViewItems.Count;
            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listView1.Columns[0].Width += 16;
            
            // Unlock
            _suspendUi = false;
        }

        private void ShowRegexResults_ByMatch()
        {
            Font matchFont = new Font(listView1.Font.FontFamily, listView1.Font.Size, FontStyle.Bold);

            for (int m = 0; m < _matches.Count; m++)
            {
                Match match = _matches[m];

                // Get next color in sequence
                int colorIndex = _project.HighlightMode == HighlightMode.Matches ?
                    m % _colors.MatchColorSchemes.Length :
                    0;

                Color matchBackColor = _colors.MatchColorSchemes[colorIndex].BackColor;
                Color matchForeColor = _colors.MatchColorSchemes[colorIndex].ForeColor;

                // Create a list item for the match
                var matchItem = GetMatchListItem(match, m);
                matchItem.BackColor = matchBackColor;
                matchItem.ForeColor = matchForeColor;
                matchItem.SubItems[0].Font = matchFont;
                _listViewItems.Add(matchItem);

                // Add group list items
                if (match.Groups.Count > 1)
                {
                    // Test each desired group
                    for (int g = 0; g < _groupNames.Length; g++)
                    {
                        var groupName = _groupNames[g];

                        // Ignore if empty
                        if (match.Groups[groupName].Success)
                        {
                            // Add list item
                            var groupItem = GetGroupListItem(match.Groups[groupName], groupName);
                            _listViewItems.Add(groupItem);
                        }
                    }
                }

                if (
                    _project.FilterMode == FilterMode.None
                    && _project.HighlightMode == HighlightMode.Matches
                    && m < _highlightingLimit
                    )
                {
                    // Highlight text
                    this.ColorInputText(
                        match.Index,
                        match.Length,
                        matchBackColor,
                        matchForeColor,
                        String.Format("Match [{0}]", m)
                        );
                }
            }
        }

        private void ShowRegexResults_ByGroups()
        {
            Font matchFont = new Font(listView1.Font.FontFamily, listView1.Font.Size, FontStyle.Bold);

            // Build a list of groups to display
            var displayGroups = new List<string>();
            bool isNumeric = false;

            if (_project.HighlightMode == HighlightMode.CustomGroups)
                displayGroups = _project.HighlightGroups;

            else
            {
                for (int i = 0; i < _groupNames.Length; i++)
                {
                    isNumeric = _groupNames[i] == i.ToString();
                    if (_project.HighlightMode == HighlightMode.UnnamedGroups && isNumeric)
                        displayGroups.Add(_groupNames[i]);

                    if (_project.HighlightMode == HighlightMode.NamedGroups && !isNumeric)
                        displayGroups.Add(_groupNames[i]);
                }
            }

            // Process each match
            for (int m = 0; m < _matches.Count; m++)
            {
                Match match = _matches[m];

                // Verify there are desired groups with success in this match
                bool hasGroups = false;
                foreach (var g in displayGroups)
                {
                    if (match.Groups[g].Success)
                    {
                        hasGroups = true;
                        break;
                    }
                }

                if (hasGroups)
                {
                    // Create a list item for the match
                    var matchItem = GetMatchListItem(match, m);
                    matchItem.BackColor = _colors.MatchBackColor;
                    matchItem.ForeColor = _colors.MatchForeColor;
                    matchItem.SubItems[0].Font = matchFont;
                    _listViewItems.Add(matchItem);

                    // Test each desired group
                    bool isDesired = false;
                    for (int g = 0; g < displayGroups.Count; g++)
                    {
                        var groupName = displayGroups[g];
                        isDesired = displayGroups.Contains(groupName);

                        // Ignore if empty
                        if (match.Groups[groupName].Success)
                        {
                            // Pick next color in sequence
                            int colorIndex = g % _colors.MatchColorSchemes.Length;
                            Color groupBackColor = _colors.MatchColorSchemes[colorIndex].BackColor;
                            Color groupForeColor = _colors.MatchColorSchemes[colorIndex].ForeColor;

                            // Add list item
                            var groupItem = GetGroupListItem(match.Groups[groupName], groupName);
                            if(isDesired)
                                groupItem.BackColor = groupBackColor;
                            _listViewItems.Add(groupItem);

                            // Color text
                            if(isDesired && groupName != "0")
                                this.ColorInputText(
                                    match.Groups[groupName].Index,
                                    match.Groups[groupName].Length,
                                    groupBackColor,
                                    groupForeColor,
                                    String.Format("Match[{0}].Groups[\"{1}\"]", m, groupName)
                                    );
                        }
                    }
                }
            }
        }

        private void ApplyFilter()
        {
            if (_project.FilterMode == FilterMode.None)
                return;

            _suspendRegex = true;

            // Get Matched data
            if (_project.FilterMode == FilterMode.MatchedData)
            {
                var sb = new StringBuilder();
                foreach (Match match in _matches)
                {
                    if (_project.NewLinePerMatchInFilterMode)
                        sb.AppendFormat("{0}\r\n", match.Value);

                    else
                        sb.Append(match.Value);
                }

                txtInput.Text = sb.ToString();
            }

            // Get unmatched Data
            else if (_project.FilterMode == FilterMode.UnmatchedData)
            {
                char[] chars = new char[_project.InputData.Length];
                bool[] matchedChars = new bool[_project.InputData.Length];

                // Mark out matched chars
                foreach (Match match in _matches)
                {
                    for (int i = match.Index; i < match.Index + match.Length; i++)
                    {
                        matchedChars[i] = true;
                    }
                }

                // Fetch the results
                int c = 0;
                for (int i = 0; i < matchedChars.Length; i++)
                {
                    if (!matchedChars[i])
                    {
                        chars[c] = _project.InputData[i];
                        c++;
                    }
                }
                Array.Resize(ref chars, c);

                txtInput.Text = new string(chars);
            }

            _suspendRegex = false;
        }

        private ListViewItem GetMatchListItem(Match match, int index)
        {
            var item = new ListViewItem(String.Format("Match [{0}]", index), 1);
            item.Tag = match;

            item.SubItems.Add(match.Index.ToString());
            item.SubItems.Add(match.Length.ToString());
            item.SubItems.Add(match.Value);

            return item;
        }

        private ListViewItem GetGroupListItem(Group group, string name)
        {
            var item = new ListViewItem(name, 2);
            item.Tag = group;
            item.IndentCount = 1;

            item.SubItems.Add(group.Index.ToString());
            item.SubItems.Add(group.Length.ToString());
            item.SubItems.Add(group.Value);

            return item;
        }

        private void ColorPatternText(int start, int length, Color foreColor)
        {
            var marker = new DigitalRune.Windows.TextEditor.Markers.Marker(
                    start,
                    length,
                    DigitalRune.Windows.TextEditor.Markers.MarkerType.SolidBlock,
                    _colors.WindowBackColor,
                    foreColor
                    );

            txtPattern.Document.MarkerStrategy.AddMarker(marker);
        }

        private void ColorInputText(int start, int length, Color backColor, Color foreColor, string tooltip = "")
        {
            var marker = new DigitalRune.Windows.TextEditor.Markers.Marker(
                    start,
                    length,
                    DigitalRune.Windows.TextEditor.Markers.MarkerType.SolidBlock,
                    backColor,
                    foreColor
                    );
            marker.ToolTip = tooltip;

            txtInput.Document.MarkerStrategy.AddMarker(marker);
        }

        #endregion

        #region Status Updates

        private void ShowStatus(string msg, Image icon)
        {
            lblStatus.Text = msg;
            lblStatus.Image = icon;
            lblStatus.Visible = true;
        }

        private void ClearStatus()
        {
            lblStatus.Visible = false;
        }

        private void ShowWarningStatus(string msg)
        {
            ShowStatus(msg, global::Regex_Tool.Properties.Resources.Warning);
        }

        private void ShowCriticalStatus(string msg)
        {
            ShowStatus(msg, global::Regex_Tool.Properties.Resources.Critical);
        }

        private void ShowSuccessStatus(string msg)
        {
            ShowStatus(msg, global::Regex_Tool.Properties.Resources.Success);
        }

        private void ShowRegexStatus(MatchCollection matches, string[] groups)
        {
            if (matches == null || matches.Count == 0)
            {
                ShowWarningStatus("No results found.");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendFormat("{0} matches found with {1} groups", matches.Count, groups.Length);

            int named = 0, unnamed = 0;
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i] == i.ToString())
                    unnamed++;
                else
                    named++;
            }

            if (named > 0)
                sb.AppendFormat(" ({0} named, {1} unnamed)", named, unnamed);
            sb.Append(".");

            if (_project.FilterMode > 0)
                sb.Append(" [FILTERED]");

            ShowStatus(sb.ToString(), global::Regex_Tool.Properties.Resources.RegexSuccess);
        }

        #endregion

        #region Project Options

        private void SetHighlightingCustom()
        {
            if (_suspendUi) return;

            var dialog = new GroupSelectorForm(_groupNames);
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                _project.HighlightMode = HighlightMode.CustomGroups;
                _project.HighlightGroups.Clear();
                _project.HighlightGroups.AddRange(dialog.SelectedGroups);

                RefreshOptionsUI();
                ShowRegexResults();
            }
        }

        private void ToggleHighlightMode(HighlightMode mode)
        {
            if(_suspendUi || _project.HighlightMode == mode)
                return;

            _project.HighlightMode = mode;

            RefreshOptionsUI();          
            ShowRegexResults();
        }

        private void ToggleFilterMode(FilterMode mode)
        {
            if (_project.FilterMode == mode)
                return;

            _project.FilterMode = mode;

            if (mode == FilterMode.None)
            {
                // Need to repopulate the input box
                _suspendRegex = true;
                txtInput.Text = _project.InputData;
                _suspendRegex = false;
            }

            RefreshOptionsUI();
            ShowRegexResults();
        }

        private void TogglePause(bool paused)
        {
            if (_project.Paused == paused)
                return;

            _project.Paused = paused;
            RefreshOptionsUI();

            if (!paused)
                RefreshRegexResults();
        }

        private void ToggleAddLineBreaks(bool add)
        {
            if (_project.NewLinePerMatchInFilterMode == add)
                return;

            _project.NewLinePerMatchInFilterMode = add;
            ShowRegexResults();
        }

        private void SetProjectRegexOptions()
        {
            // Update Project options from the UI
            this._project.RegexOptions = RegexOptions.None;

            if (this.chkCompiled.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.Compiled;

            if (this.chkCultureInvariant.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.CultureInvariant;

            if (this.chkEcmaScript.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.ECMAScript;

            if (this.chkExplicitCapture.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.ExplicitCapture;

            if (this.chkIgnoreCase.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.IgnoreCase;

            if (this.chkIgnorePatternWhitespace.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.IgnorePatternWhitespace;

            if (this.chkMultiline.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.Multiline;

            if (this.chkRightToLeft.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.RightToLeft;

            if (this.chkSingleline.Checked)
                _project.RegexOptions = _project.RegexOptions | RegexOptions.Singleline;

            // Save options to settings
            Settings.Default.RegexOptions = this._project.RegexOptions;
            Settings.Default.Save();

            // Update results with new options
            this.RefreshRegexResults();
        }

        #endregion

        #region Project IO

        private void LoadInitSettings()
        {
            // Options
            var project = new Project
            {
                RegexOptions = Settings.Default.RegexOptions,
                Pattern = Settings.Default.LastPattern,
                InputData = Settings.Default.LastInput,
                InconsistentState = false
            };
            
            // Default text color
            HighlightingManager.Manager.DefaultHighlighting.SetColorFor(
                "Default",
                new HighlightColor(_colors.WindowForeColor, _colors.WindowBackColor, false, false)
                );

            //Selections
            HighlightingManager.Manager.DefaultHighlighting.SetColorFor(
                "Selection",
                new HighlightColor(_colors.HighlightForeColor, _colors.HighlightBackColor, false, false)
                );

            // Default text color
            HighlightingManager.Manager.DefaultHighlighting.SetColorFor(
                "LineNumbers",
                new HighlightColor(_colors.WindowForeColor, _colors.WindowBackColor, false, false)
                );

            // Show project
            LoadProject(project);
        }

        private void LoadProject(Project project)
        {
            _project = project;

            // Set title bar
            var fileName = String.IsNullOrEmpty(_project.FileName) ?
                "New Project" :
                Path.GetFileNameWithoutExtension(_project.FileName);

            this.Text = String.Format("{0} - {1}", Application.ProductName, fileName);

            // Load all project options
            RefreshOptionsUI();

            // Load pattern & data
            _suspendRegex = true;
            txtPattern.Text = _project.Pattern;
            txtInput.Text = _project.InputData;
            _suspendRegex = false;
            RefreshRegexResults();
        }

        private void NewProject()
        {
            if (CheckProjectState())
            {
                this.LoadProject(new Project());
            }
        }

        private void OpenProject()
        {
            if (CheckProjectState())
            {
                var dialog = new OpenFileDialog
                {
                    Filter = "Project Files (*.elpx)|*.elpx|XML Files|*.xml|All Files|*.*"
                };

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    OpenProject(dialog.FileName);
                }
            }
        }

        public void OpenProject(string path)
        {
            try
            {
                LoadProject(Project.FromFile(path));
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.Message,
                    "Error opening project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void RefreshOptionsUI()
        {
            _suspendUi = true;

            // Highlight mode controls
            btnHighlighMatchesNone.Checked = _project.HighlightMode == HighlightMode.None;
            btnHighlightMatches.Checked = _project.HighlightMode == HighlightMode.Matches;
            btnHighlightGroupsUnnamed.Checked = _project.HighlightMode == HighlightMode.UnnamedGroups;
            btnHighlightGroupsNamed.Checked = _project.HighlightMode == HighlightMode.NamedGroups;
            btnHighlightCustom.Checked = _project.HighlightMode == HighlightMode.CustomGroups;

            // Filter mode controls
            txtInput.IsReadOnly = _project.FilterMode != FilterMode.None;

            btnFilterNone.Checked = _project.FilterMode == FilterMode.None;

            btnFilterMatchedData.Checked = _project.FilterMode == FilterMode.MatchedData;

            btnFilterUnmatchedData.Checked = _project.FilterMode == FilterMode.UnmatchedData;

            btnAddLineBreaks.Enabled = _project.FilterMode != FilterMode.None;
            btnAddLineBreaks.Checked = _project.NewLinePerMatchInFilterMode;

            // Regex Option Controls
            this.chkCompiled.Checked = RegexOptions.Compiled == (this._project.RegexOptions & RegexOptions.Compiled);
            this.chkCultureInvariant.Checked = RegexOptions.CultureInvariant == (this._project.RegexOptions & RegexOptions.CultureInvariant);
            this.chkEcmaScript.Checked = RegexOptions.ECMAScript == (this._project.RegexOptions & RegexOptions.ECMAScript);
            this.chkExplicitCapture.Checked = RegexOptions.ExplicitCapture == (this._project.RegexOptions & RegexOptions.ExplicitCapture);
            this.chkIgnoreCase.Checked = RegexOptions.IgnoreCase == (this._project.RegexOptions & RegexOptions.IgnoreCase);
            this.chkIgnorePatternWhitespace.Checked = RegexOptions.IgnorePatternWhitespace == (this._project.RegexOptions & RegexOptions.IgnorePatternWhitespace);
            this.chkMultiline.Checked = RegexOptions.Multiline == (this._project.RegexOptions & RegexOptions.Multiline);
            this.chkRightToLeft.Checked = RegexOptions.RightToLeft == (this._project.RegexOptions & RegexOptions.RightToLeft);
            this.chkSingleline.Checked = RegexOptions.Singleline == (this._project.RegexOptions & RegexOptions.Singleline);
            
            // Pause button controls
            btnPause.Text = _project.Paused ? "Resume" : "Pause";
            btnPause.ToolTipText = _project.Paused ? "Resume processing Regex" : "Pause processing Regex";
            btnPause.Image = _project.Paused ?
                global::Regex_Tool.Properties.Resources.Play :
                global::Regex_Tool.Properties.Resources.Pause;

            _suspendUi = false;
        }

        private bool SaveProject()
        {
            if (String.IsNullOrEmpty(_project.FileName))
                return SaveProjectAs();
            
            _project.Save();
            return true;
        }

        private bool SaveProjectAs()
        {
            var dialog = new SaveFileDialog
            {
                Filter = "EL Project Files (*.elpx)|*.elpx|XML Files|*.xml|All Files|*.*",
                DefaultExt = "elpx",
                AddExtension = true
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _project.Save(dialog.FileName);
                LoadProject(_project);
                return true;
            }

            return false;
        }

        private void ImportDataFromFile(TextEditorControl target)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt;*.csv;*.xml|All Files|*.*"
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                target.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void ExportDataToFile(TextEditorControl target)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Save File",
                Filter = "Text File|*.txt|XML File|*.xml|All Files|*.*",
                AddExtension = true
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, target.Text);
            }
        }

        /// <summary>
        /// Returns true if the current project is in a consistent state or
        /// the user has agreed to discard changes.
        /// </summary>
        /// <returns></returns>
        private bool CheckProjectState()
        {
            if (!_project.InconsistentState) return true;

            var choice = MessageBox.Show(
                this,
                "Save your current project before proceeding?",
                "Save Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            switch (choice)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    return SaveProject();

                case System.Windows.Forms.DialogResult.No:
                    return true;

                default:
                    return false;
            }
        }

        private void Exit()
        {
            Application.Exit();
        }

        #endregion

        #region Clipboard

        private void CopyDataToClipboard()
        {
            Clipboard.SetText(txtInput.Text);
        }

        private void ExportPatternAsCsVariable()
        {
            var lines = this.txtPattern.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var data = String.Join("\"\r\n\t+ @\"", lines);
            var code = String.Format("string pattern = \r\n\t@\"{0}\";", data);

            Clipboard.SetText(code);
        }

        #endregion

        #region Drawing

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle r = e.Bounds;
            //r.Y += 1; r.Height -= 1; r.Width -= 1;
                
            // Select backcolor
            Color backColor = ((e.ItemState & ListViewItemStates.Selected) != 0) ?
                _colors.HighlightBackColor :
                e.Item.BackColor;

            Color foreColor = ((e.ItemState & ListViewItemStates.Selected) != 0) ? 
                _colors.HighlightForeColor :
                e.Item.ForeColor;

            // Paint background.
            e.Graphics.FillRectangle(new SolidBrush(_colors.Grid), r);
            r.Height -= 1; r.Width -= 1;
            e.Graphics.FillRectangle(new SolidBrush(backColor), r);
            
            if (e.ColumnIndex == 0)
            {
                // calculate x offset from ident-level
                int xOffset = e.Item.IndentCount * 16;

                // calculate x position
                int xPos = e.Bounds.X + xOffset + 16;
                
                // First column & Icon
                //e.Graphics.FillRectangle(new SolidBrush(backColor), r);

                // Draw icon
                r.Height = 16;
                r.Width = 16;
                r.X = e.Bounds.X + xOffset + 1;
                r.Y = e.Bounds.Y;
                e.Graphics.DrawImage(e.Item.ImageList.Images[e.Item.ImageIndex], r);

                // set rectangle bounds for drawing of item/subitem text
                r.Height = e.Bounds.Height;
                r.Width = e.Bounds.Width - xPos;
                r.X = xPos;
                r.Y = e.Bounds.Y;
            }
            
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, r, foreColor, _textFormatFlags);
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Do nothing
        }

        #endregion

        #region UI Handlers

        private void RegexDataChanged(object sender, EventArgs e)
        {
            this.RegexDataChanged();
        }

        private void RegexDataChanged(object sender, DigitalRune.Windows.TextEditor.Document.DocumentEventArgs e)
        {
            this.RegexDataChanged();
        }

        private void RegexOptionChecked(object sender, EventArgs e)
        {
            if (_suspendUi)
                return;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;

            SetProjectRegexOptions();
        }

        private void SetFilterAddLineBreaks(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;

            ToggleAddLineBreaks(item.Checked);
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = _listViewItems[e.ItemIndex];
        }

        private void SelectCapture(object sender, EventArgs e)
        {
            if (_project.FilterMode == FilterMode.None && listView1.SelectedIndices.Count == 1)
            {
                var capture = (Capture)_listViewItems[listView1.SelectedIndices[0]].Tag;

                var i = txtInput.Document.OffsetToPosition(capture.Index);
                txtInput.ActiveTextAreaControl.Caret.Position = i;
                
                txtInput.ActiveTextAreaControl.ScrollToCaret();
                txtInput.ActiveTextAreaControl.Focus();
            }
        }

        private void NewProject(object sender, EventArgs e)
        {
            NewProject();
        }

        private void SaveProjectAs(object sender, EventArgs e)
        {
            SaveProjectAs();
        }

        private void SaveProject(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void OpenProject(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void SetFilterNone(object sender, EventArgs e)
        {
            ToggleFilterMode(FilterMode.None);
        }

        private void SetFilterMatchedData(object sender, EventArgs e)
        {
            ToggleFilterMode(FilterMode.MatchedData);
        }

        private void SetFilterUnmatchedData(object sender, EventArgs e)
        {
            ToggleFilterMode(FilterMode.UnmatchedData);
        }

        private void Pause(object sender, EventArgs e)
        {
            TogglePause(!_project.Paused);
        }

        private void ExportDataToFile(object sender, EventArgs e)
        {
            this.ExportDataToFile(txtInput);
        }

        private void ExportPatternToFile(object sender, EventArgs e)
        {
            this.ExportDataToFile(txtPattern);
        }

        private void textEditorControl_Enter(object sender, EventArgs e)
        {
            _activeControl = (TextEditorControl)sender;
        }

        private void Paste(object sender, EventArgs e)
        {
            _activeControl.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste();
        }

        private void Cut(object sender, EventArgs e)
        {
            _activeControl.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut();
        }

        private void Copy(object sender, EventArgs e)
        {
            _activeControl.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy();
        }

        private void Undo(object sender, EventArgs e)
        {
            _activeControl.Undo();
        }

        private void Redo(object sender, EventArgs e)
        {
            _activeControl.Redo();
        }

        private void SelectAll(object sender, EventArgs e)
        {
            _activeControl.ActiveTextAreaControl.TextArea.ClipboardHandler.SelectAll();
        }

        private void Exit(object sender, EventArgs e)
        {
            Exit();
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CheckProjectState();
           
            // Update settings
            Settings.Default.LastPattern = this.txtPattern.Text;
            Settings.Default.LastInput = this.txtInput.Text;
            Settings.Default.RegexOptions = this._project.RegexOptions;
            Settings.Default.Save();

        }

        private void ImportDataFromFile(object sender, EventArgs e)
        {
            ImportDataFromFile(txtInput);
        }

        private void ImportPatternFromFile(object sender, EventArgs e)
        {
            ImportDataFromFile(txtPattern);
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            var dialog = new AboutForm();
            dialog.Show(this);
        }

        private void SetHighlightMatches(object sender, EventArgs e)
        {
            ToggleHighlightMode(HighlightMode.Matches);
        }

        private void SetHighlightGroupsUnnamed(object sender, EventArgs e)
        {
            ToggleHighlightMode(HighlightMode.UnnamedGroups);
        }

        private void SetHighlightGroupsNamed(object sender, EventArgs e)
        {
            ToggleHighlightMode(HighlightMode.NamedGroups);
        }

        private void SetHighlightNone(object sender, EventArgs e)
        {
            ToggleHighlightMode(HighlightMode.None);
        }

        private void SetHighlightCustom(object sender, EventArgs e)
        {
            SetHighlightingCustom();
        }

        private void ExportPatternAsCsVariable(object sender, EventArgs e)
        {
            ExportPatternAsCsVariable();
        }

        #endregion
    }
}
