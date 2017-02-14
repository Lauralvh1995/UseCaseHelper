using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case
{
    public partial class Info : Form
    {
        public string name { get; set; }
        public string summary { get; set; }
        public string actors { get; set; }
        public string assumptions { get; set; }
        public string description { get; set; }
        public string exceptions { get; set; }
        public string result { get; set; }
        public Info()
        {
            InitializeComponent();
        }

        public void UpdateForm()
        {
            tbName.Text = name;
            tbSummary.Text = summary;
            tbActors.Text = actors;
            tbAssumpt.Text = assumptions;
            tbDesc.Text = description;
            tbExcept.Text = exceptions;
            tbResult.Text = result;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            summary = tbSummary.Text;
            actors = tbActors.Text;
            assumptions = tbAssumpt.Text;
            description = tbDesc.Text;
            exceptions = tbExcept.Text;
            result = tbResult.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
