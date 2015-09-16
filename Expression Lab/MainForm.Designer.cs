using Regex_Tool.Properties;
namespace Regex_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInput = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveProjectAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportPatternFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportDataFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportPatternToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportDataToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRegexOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.chkCompiled = new System.Windows.Forms.ToolStripMenuItem();
            this.chkCultureInvariant = new System.Windows.Forms.ToolStripMenuItem();
            this.chkEcmaScript = new System.Windows.Forms.ToolStripMenuItem();
            this.chkExplicitCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.chkIgnoreCase = new System.Windows.Forms.ToolStripMenuItem();
            this.chkIgnorePatternWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMultiline = new System.Windows.Forms.ToolStripMenuItem();
            this.chkRightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSingleline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHighlighting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnHighlighMatchesNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHighlightMatches = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHighlightGroupsUnnamed = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHighlightGroupsNamed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHighlightCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilter = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFilterNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterMatchedData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilterUnmatchedData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddLineBreaks = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtPattern = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportPatternToCsVariable = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(944, 393);
            this.splitContainer1.SplitterDistance = 685;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Name = "txtInput";
            this.txtInput.ShowMatchingBracket = false;
            this.txtInput.ShowVRuler = false;
            this.txtInput.Size = new System.Drawing.Size(685, 393);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.RegexDataChanged);
            this.txtInput.Enter += new System.EventHandler(this.textEditorControl_Enter);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.LabelWrap = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(255, 393);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualMode = true;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.SelectCapture);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Index";
            this.columnHeader2.Width = 25;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Length";
            this.columnHeader3.Width = 25;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 25;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "Matches");
            this.imageList1.Images.SetKeyName(1, "Match");
            this.imageList1.Images.SetKeyName(2, "Group");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.toolStripSeparator3,
            this.mnuRegexOptions,
            this.toolStripSeparator2,
            this.mnuHighlighting,
            this.mnuFilter,
            this.btnPause,
            this.toolStripSeparator4,
            this.mnuHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewProject,
            this.btnOpenProject,
            this.toolStripSeparator16,
            this.btnSave,
            this.btnSaveProjectAs,
            this.toolStripSeparator17,
            this.toolStripMenuItem13,
            this.exportToolStripMenuItem,
            this.toolStripSeparator18,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripSeparator19,
            this.btnExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuFile.ShowDropDownArrow = false;
            this.mnuFile.Size = new System.Drawing.Size(37, 22);
            this.mnuFile.Text = "&File";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProject.Image")));
            this.btnNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewProject.Size = new System.Drawing.Size(152, 22);
            this.btnNewProject.Text = "&New";
            this.btnNewProject.Click += new System.EventHandler(this.NewProject);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProject.Image")));
            this.btnOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenProject.Size = new System.Drawing.Size(152, 22);
            this.btnOpenProject.Text = "&Open";
            this.btnOpenProject.Click += new System.EventHandler(this.OpenProject);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(149, 6);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(152, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.SaveProject);
            // 
            // btnSaveProjectAs
            // 
            this.btnSaveProjectAs.Name = "btnSaveProjectAs";
            this.btnSaveProjectAs.Size = new System.Drawing.Size(152, 22);
            this.btnSaveProjectAs.Text = "Save &As";
            this.btnSaveProjectAs.Click += new System.EventHandler(this.SaveProjectAs);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportPatternFromFile,
            this.btnImportDataFromFile});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem13.Text = "&Import";
            // 
            // btnImportPatternFromFile
            // 
            this.btnImportPatternFromFile.Name = "btnImportPatternFromFile";
            this.btnImportPatternFromFile.Size = new System.Drawing.Size(178, 22);
            this.btnImportPatternFromFile.Text = "Test &Pattern from File";
            this.btnImportPatternFromFile.Click += new System.EventHandler(this.ImportPatternFromFile);
            // 
            // btnImportDataFromFile
            // 
            this.btnImportDataFromFile.Name = "btnImportDataFromFile";
            this.btnImportDataFromFile.Size = new System.Drawing.Size(178, 22);
            this.btnImportDataFromFile.Text = "Test &Data from File";
            this.btnImportDataFromFile.Click += new System.EventHandler(this.ImportDataFromFile);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportPatternToFile,
            this.btnExportDataToFile,
            this.toolStripSeparator7,
            this.btnExportPatternToCsVariable});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // btnExportPatternToFile
            // 
            this.btnExportPatternToFile.Name = "btnExportPatternToFile";
            this.btnExportPatternToFile.Size = new System.Drawing.Size(244, 22);
            this.btnExportPatternToFile.Text = "&Pattern to File";
            this.btnExportPatternToFile.Click += new System.EventHandler(this.ExportPatternToFile);
            // 
            // btnExportDataToFile
            // 
            this.btnExportDataToFile.Name = "btnExportDataToFile";
            this.btnExportDataToFile.Size = new System.Drawing.Size(244, 22);
            this.btnExportDataToFile.Text = "&Data to File";
            this.btnExportDataToFile.Click += new System.EventHandler(this.ExportDataToFile);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem16.Image")));
            this.toolStripMenuItem16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem16.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem16.Text = "&Print";
            this.toolStripMenuItem16.Visible = false;
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem17.Image")));
            this.toolStripMenuItem17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem17.Text = "Print Pre&view";
            this.toolStripMenuItem17.Visible = false;
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator19.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 22);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator14,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator15,
            this.btnSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuEdit.ShowDropDownArrow = false;
            this.mnuEdit.Size = new System.Drawing.Size(39, 22);
            this.mnuEdit.Text = "&Edit";
            // 
            // btnUndo
            // 
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnUndo.Size = new System.Drawing.Size(139, 22);
            this.btnUndo.Text = "&Undo";
            this.btnUndo.Click += new System.EventHandler(this.Undo);
            // 
            // btnRedo
            // 
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.btnRedo.Size = new System.Drawing.Size(139, 22);
            this.btnRedo.Text = "&Redo";
            this.btnRedo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(136, 6);
            // 
            // btnCut
            // 
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.Name = "btnCut";
            this.btnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCut.Size = new System.Drawing.Size(139, 22);
            this.btnCut.Text = "Cu&t";
            this.btnCut.Click += new System.EventHandler(this.Cut);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopy.Size = new System.Drawing.Size(139, 22);
            this.btnCopy.Text = "&Copy";
            this.btnCopy.Click += new System.EventHandler(this.Copy);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPaste.Size = new System.Drawing.Size(139, 22);
            this.btnPaste.Text = "&Paste";
            this.btnPaste.Click += new System.EventHandler(this.Paste);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(136, 6);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(139, 22);
            this.btnSelectAll.Text = "Select &All";
            this.btnSelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuRegexOptions
            // 
            this.mnuRegexOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkCompiled,
            this.chkCultureInvariant,
            this.chkEcmaScript,
            this.chkExplicitCapture,
            this.chkIgnoreCase,
            this.chkIgnorePatternWhitespace,
            this.chkMultiline,
            this.chkRightToLeft,
            this.chkSingleline});
            this.mnuRegexOptions.Image = global::Regex_Tool.Properties.Resources.Options;
            this.mnuRegexOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuRegexOptions.Name = "mnuRegexOptions";
            this.mnuRegexOptions.Size = new System.Drawing.Size(107, 22);
            this.mnuRegexOptions.Text = "&Regex Options";
            // 
            // chkCompiled
            // 
            this.chkCompiled.Name = "chkCompiled";
            this.chkCompiled.Size = new System.Drawing.Size(198, 22);
            this.chkCompiled.Text = "&Compiled";
            this.chkCompiled.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkCultureInvariant
            // 
            this.chkCultureInvariant.Name = "chkCultureInvariant";
            this.chkCultureInvariant.Size = new System.Drawing.Size(198, 22);
            this.chkCultureInvariant.Text = "C&ultureInvariant";
            this.chkCultureInvariant.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkEcmaScript
            // 
            this.chkEcmaScript.Name = "chkEcmaScript";
            this.chkEcmaScript.Size = new System.Drawing.Size(198, 22);
            this.chkEcmaScript.Text = "&ECMAScript";
            this.chkEcmaScript.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkExplicitCapture
            // 
            this.chkExplicitCapture.Name = "chkExplicitCapture";
            this.chkExplicitCapture.Size = new System.Drawing.Size(198, 22);
            this.chkExplicitCapture.Text = "E&xplicitCapture";
            this.chkExplicitCapture.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(198, 22);
            this.chkIgnoreCase.Text = "&IgnoreCase";
            this.chkIgnoreCase.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkIgnorePatternWhitespace
            // 
            this.chkIgnorePatternWhitespace.Name = "chkIgnorePatternWhitespace";
            this.chkIgnorePatternWhitespace.Size = new System.Drawing.Size(198, 22);
            this.chkIgnorePatternWhitespace.Text = "Ignore&PatternWhitespace";
            this.chkIgnorePatternWhitespace.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkMultiline
            // 
            this.chkMultiline.Name = "chkMultiline";
            this.chkMultiline.Size = new System.Drawing.Size(198, 22);
            this.chkMultiline.Text = "&Multiline";
            this.chkMultiline.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkRightToLeft
            // 
            this.chkRightToLeft.Name = "chkRightToLeft";
            this.chkRightToLeft.Size = new System.Drawing.Size(198, 22);
            this.chkRightToLeft.Text = "&RightToLeft";
            this.chkRightToLeft.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // chkSingleline
            // 
            this.chkSingleline.Name = "chkSingleline";
            this.chkSingleline.Size = new System.Drawing.Size(198, 22);
            this.chkSingleline.Text = "&Singleline";
            this.chkSingleline.Click += new System.EventHandler(this.RegexOptionChecked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuHighlighting
            // 
            this.mnuHighlighting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHighlighMatchesNone,
            this.toolStripSeparator1,
            this.btnHighlightMatches,
            this.btnHighlightGroupsUnnamed,
            this.btnHighlightGroupsNamed,
            this.toolStripSeparator5,
            this.btnHighlightCustom});
            this.mnuHighlighting.Image = global::Regex_Tool.Properties.Resources.Highlighting;
            this.mnuHighlighting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHighlighting.Name = "mnuHighlighting";
            this.mnuHighlighting.Size = new System.Drawing.Size(91, 22);
            this.mnuHighlighting.Text = "Highlighting";
            // 
            // btnHighlighMatchesNone
            // 
            this.btnHighlighMatchesNone.Name = "btnHighlighMatchesNone";
            this.btnHighlighMatchesNone.Size = new System.Drawing.Size(164, 22);
            this.btnHighlighMatchesNone.Text = "&None";
            this.btnHighlighMatchesNone.Click += new System.EventHandler(this.SetHighlightNone);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // btnHighlightMatches
            // 
            this.btnHighlightMatches.Name = "btnHighlightMatches";
            this.btnHighlightMatches.Size = new System.Drawing.Size(164, 22);
            this.btnHighlightMatches.Text = "&Matches";
            this.btnHighlightMatches.Click += new System.EventHandler(this.SetHighlightMatches);
            // 
            // btnHighlightGroupsUnnamed
            // 
            this.btnHighlightGroupsUnnamed.Name = "btnHighlightGroupsUnnamed";
            this.btnHighlightGroupsUnnamed.Size = new System.Drawing.Size(164, 22);
            this.btnHighlightGroupsUnnamed.Text = "Groups (Unnamed)";
            this.btnHighlightGroupsUnnamed.Click += new System.EventHandler(this.SetHighlightGroupsUnnamed);
            // 
            // btnHighlightGroupsNamed
            // 
            this.btnHighlightGroupsNamed.Name = "btnHighlightGroupsNamed";
            this.btnHighlightGroupsNamed.Size = new System.Drawing.Size(164, 22);
            this.btnHighlightGroupsNamed.Text = "Groups (Named)";
            this.btnHighlightGroupsNamed.Click += new System.EventHandler(this.SetHighlightGroupsNamed);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // btnHighlightCustom
            // 
            this.btnHighlightCustom.Name = "btnHighlightCustom";
            this.btnHighlightCustom.Size = new System.Drawing.Size(164, 22);
            this.btnHighlightCustom.Text = "Custom";
            this.btnHighlightCustom.Click += new System.EventHandler(this.SetHighlightCustom);
            // 
            // mnuFilter
            // 
            this.mnuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFilterNone,
            this.toolStripSeparator6,
            this.btnFilterMatchedData,
            this.btnFilterUnmatchedData,
            this.toolStripSeparator13,
            this.btnAddLineBreaks});
            this.mnuFilter.Image = global::Regex_Tool.Properties.Resources.Filter;
            this.mnuFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFilter.Name = "mnuFilter";
            this.mnuFilter.Size = new System.Drawing.Size(60, 22);
            this.mnuFilter.Text = "Filter";
            // 
            // btnFilterNone
            // 
            this.btnFilterNone.Name = "btnFilterNone";
            this.btnFilterNone.Size = new System.Drawing.Size(154, 22);
            this.btnFilterNone.Text = "&No Filter";
            this.btnFilterNone.Click += new System.EventHandler(this.SetFilterNone);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(151, 6);
            // 
            // btnFilterMatchedData
            // 
            this.btnFilterMatchedData.Name = "btnFilterMatchedData";
            this.btnFilterMatchedData.Size = new System.Drawing.Size(154, 22);
            this.btnFilterMatchedData.Text = "&Matched Data";
            this.btnFilterMatchedData.Click += new System.EventHandler(this.SetFilterMatchedData);
            // 
            // btnFilterUnmatchedData
            // 
            this.btnFilterUnmatchedData.Name = "btnFilterUnmatchedData";
            this.btnFilterUnmatchedData.Size = new System.Drawing.Size(154, 22);
            this.btnFilterUnmatchedData.Text = "&Unmatched Data";
            this.btnFilterUnmatchedData.Click += new System.EventHandler(this.SetFilterUnmatchedData);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(151, 6);
            // 
            // btnAddLineBreaks
            // 
            this.btnAddLineBreaks.Name = "btnAddLineBreaks";
            this.btnAddLineBreaks.Size = new System.Drawing.Size(154, 22);
            this.btnAddLineBreaks.Text = "Add &Line Breaks";
            this.btnAddLineBreaks.Click += new System.EventHandler(this.SetFilterAddLineBreaks);
            // 
            // btnPause
            // 
            this.btnPause.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPause.Image = global::Regex_Tool.Properties.Resources.Pause;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(56, 22);
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.Pause);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuHelp.ShowDropDownArrow = false;
            this.mnuHelp.Size = new System.Drawing.Size(42, 22);
            this.mnuHelp.Text = "&Help";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(103, 22);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.ShowAbout);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Image = global::Regex_Tool.Properties.Resources.Warning;
            this.lblStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 17);
            this.lblStatus.Text = "Error";
            this.lblStatus.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtPattern);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(944, 515);
            this.splitContainer2.SplitterDistance = 118;
            this.splitContainer2.TabIndex = 3;
            // 
            // txtPattern
            // 
            this.txtPattern.AutoScroll = true;
            this.txtPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPattern.Location = new System.Drawing.Point(0, 0);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.ShowLineNumbers = false;
            this.txtPattern.ShowMatchingBracket = false;
            this.txtPattern.ShowVRuler = false;
            this.txtPattern.Size = new System.Drawing.Size(944, 118);
            this.txtPattern.TabIndex = 2;
            this.txtPattern.Text = "textEditorControl1";
            this.txtPattern.TextChanged += new System.EventHandler(this.RegexDataChanged);
            this.txtPattern.Enter += new System.EventHandler(this.textEditorControl_Enter);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(241, 6);
            // 
            // btnExportPatternToCsVariable
            // 
            this.btnExportPatternToCsVariable.Name = "btnExportPatternToCsVariable";
            this.btnExportPatternToCsVariable.Size = new System.Drawing.Size(244, 22);
            this.btnExportPatternToCsVariable.Text = "Pattern to Clipboard as C# &Variable";
            this.btnExportPatternToCsVariable.Click += new System.EventHandler(this.ExportPatternAsCsVariable);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Expression Lab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DigitalRune.Windows.TextEditor.TextEditorControl txtInput;
        private DigitalRune.Windows.TextEditor.TextEditorControl txtPattern;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripDropDownButton mnuFilter;
        private System.Windows.Forms.ToolStripMenuItem btnFilterNone;
        private System.Windows.Forms.ToolStripMenuItem btnFilterMatchedData;
        private System.Windows.Forms.ToolStripMenuItem btnFilterUnmatchedData;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem btnAddLineBreaks;
        private System.Windows.Forms.ToolStripDropDownButton mnuHighlighting;
        private System.Windows.Forms.ToolStripMenuItem btnHighlightMatches;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton mnuFile;
        private System.Windows.Forms.ToolStripMenuItem btnNewProject;
        private System.Windows.Forms.ToolStripMenuItem btnOpenProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveProjectAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem btnImportPatternFromFile;
        private System.Windows.Forms.ToolStripMenuItem btnImportDataFromFile;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExportPatternToFile;
        private System.Windows.Forms.ToolStripMenuItem btnExportDataToFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripDropDownButton mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem btnUndo;
        private System.Windows.Forms.ToolStripMenuItem btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripDropDownButton mnuRegexOptions;
        private System.Windows.Forms.ToolStripMenuItem chkCompiled;
        private System.Windows.Forms.ToolStripMenuItem chkCultureInvariant;
        private System.Windows.Forms.ToolStripMenuItem chkEcmaScript;
        private System.Windows.Forms.ToolStripMenuItem chkExplicitCapture;
        private System.Windows.Forms.ToolStripMenuItem chkIgnoreCase;
        private System.Windows.Forms.ToolStripMenuItem chkIgnorePatternWhitespace;
        private System.Windows.Forms.ToolStripMenuItem chkMultiline;
        private System.Windows.Forms.ToolStripMenuItem chkRightToLeft;
        private System.Windows.Forms.ToolStripMenuItem chkSingleline;
        private System.Windows.Forms.ToolStripDropDownButton mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnHighlighMatchesNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnHighlightGroupsUnnamed;
        private System.Windows.Forms.ToolStripMenuItem btnHighlightGroupsNamed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnHighlightCustom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem btnExportPatternToCsVariable;
    }
}

