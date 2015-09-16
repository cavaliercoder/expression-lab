using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Regex_Tool
{
    public partial class GroupSelectorForm : Form
    {
        public GroupSelectorForm()
        {
            InitializeComponent();
        }

        public GroupSelectorForm(string[] availableGroups)
            : this()
        {
            foreach (var group in availableGroups)
                listView1.Items.Add(group);
        }

        public String[] SelectedGroups
        {
            get
            {
                var selected = new List<String>(this.listView1.Items.Count);
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    selected.Add(item.Text);
                }

                return selected.ToArray();
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void Confirm(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
