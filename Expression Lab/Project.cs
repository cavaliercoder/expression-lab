namespace Regex_Tool
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using System.Drawing;
    using System.Windows.Forms;
    
    public class Project
    {
        #region Constructors

        public Project()
        {
            this.HighlightGroups = new List<string>();
            this.InconsistentState = false;
            this.Version = Application.ProductVersion;
        }

        public static Project FromFile(string path)
        {
            var project = DataFile.Load<Project>(path);
            project.FileName = path;
            project.InconsistentState = false;

            return project;
        }

        #endregion

        #region Fields

        string _pattern = String.Empty;

        string _inputData = string.Empty;

        RegexOptions _regexOptions = RegexOptions.None;

        HighlightMode _highlightMode = HighlightMode.Matches;

        FilterMode _filterMode = FilterMode.None;

        bool _newLinePerMatchInFilterMode = true;

        bool _paused = false;

        bool _inconsistentState = false;

        bool _pauseStateMgmt = false;

        #endregion

        #region Properties

        [XmlAttribute]
        public string Version { get; set; }

        [XmlIgnore]
        public String FileName { get; set; }

        public String Pattern
        {
            get
            {
                return _pattern;
            }

            set
            {
                if (value != _pattern)
                    InconsistentState = true;

                _pattern = value;
            }
        }

        public String InputData 
        {
            get
            {
                return _inputData;
            }

            set
            {
                if (value != _inputData)
                    InconsistentState = true;

                _inputData = value;
            }
        }

        public RegexOptions RegexOptions { get; set; }

        public HighlightMode HighlightMode
        {
            get { return _highlightMode; }

            set
            {
                if(value != _highlightMode)
                    InconsistentState = true;

                _highlightMode = value;
            }
        }

        public List<String> HighlightGroups { get; set; }

        public FilterMode FilterMode
        {
            get { return _filterMode; }

            set 
            {
                if(value != _filterMode)
                    InconsistentState = true;

                _filterMode = value;
            }
        }

        public bool NewLinePerMatchInFilterMode
        {
            get { return this._newLinePerMatchInFilterMode; }

            set
            {
                if (value != _newLinePerMatchInFilterMode)
                    InconsistentState = true;

                _newLinePerMatchInFilterMode = value;
            }
        }

        /// <summary>Gets whether changes to the Regex pattern and input data will be processed.</summary>
        public bool Paused
        {
            get { return _paused; }

            set
            {
                if(value != _paused)
                    InconsistentState = true;

                _paused = value;
            }
        }

        /// <summary>Gets whether changes to the project have not been committed to disk.</summary>
        [XmlIgnore]
        public bool InconsistentState
        {
            get { return _inconsistentState; }

            set
            {
                if (!_pauseStateMgmt)
                    _inconsistentState = value;
            }
        }

        #endregion

        #region Methods

        public void Save(string path)
        {
            FileName = path;
            DataFile.Save<Project>(this, path);
            InconsistentState = false;
        }

        public void Save()
        {
            if (String.IsNullOrEmpty(FileName))
                throw new ArgumentException("Please specify a path.");

            Save(FileName);
        }

        #endregion
    }

    #region Enums

    public enum HighlightMode
    {
        None = 0,
        Matches = 1,
        UnnamedGroups = 2,
        NamedGroups = 3,
        CustomGroups = 4
    }

    public enum FilterMode
    {
        None = 0,
        MatchedData = 1,
        UnmatchedData = 2
    }

    #endregion
}