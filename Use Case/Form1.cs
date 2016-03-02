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
    public partial class Form1 : Form
    {
        List<UseCase> usecase = new List<UseCase>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pbUseCase_MouseDown(object sender, MouseEventArgs e)
        {
            UseCase ucs = new UseCase(e.Location);
            usecase.Add(ucs);
            pbUseCase.Refresh();

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }

        private void pbUseCase_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pbUseCase_Paint(object sender, PaintEventArgs e)
        {
           
            foreach (UseCase ucs in usecase)
            {
                ucs.Draw(e.Graphics);
            }
        
        }
    }
}
