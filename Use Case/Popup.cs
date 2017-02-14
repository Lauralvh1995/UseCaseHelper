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
    public partial class Popup : Form
    {
        private TextBox tbName;
        private Button btDone;
        private Label lbName;
        private string word;

        public Popup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.btDone = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 66);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 22);
            this.tbName.TabIndex = 0;
            // 
            // btDone
            // 
            this.btDone.Location = new System.Drawing.Point(128, 94);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(75, 23);
            this.btDone.TabIndex = 1;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click_1);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(106, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(139, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Please enter a name";
            // 
            // Popup
            // 
            this.ClientSize = new System.Drawing.Size(333, 129);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.tbName);
            this.Name = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string Word
        {
            get
            {
                return word;
            }
            private set
            {
                word = value;
            }
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            if (tbName.TextLength > 0)
            {
                Word = tbName.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btDone_Click_1(object sender, EventArgs e)
        {
            if (tbName.TextLength > 0)
            {
                Word = tbName.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
