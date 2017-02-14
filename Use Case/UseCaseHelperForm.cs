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
    public enum Selection
    {
        Normal,
        Highlight,
        Selected
    }
    public partial class UseCaseHelperForm : Form
    {
        List<UseCase> usecase = new List<UseCase>();
        List<Actor> actors = new List<Actor>();
        List<Line> lines = new List<Line>();
        Point start;
        Point end;
        int completed;

        public UseCaseHelperForm()
        {
            InitializeComponent();
        }

        private void pbUseCase_MouseDown(object sender, MouseEventArgs e)
        {
            if (rBtCreate.Checked)
            {
                if (rBtLine.Checked)
                {
                    if (completed == 0)
                    {
                        start = e.Location;
                        completed = 1;
                    }
                    else if (completed == 1)
                    {
                        end = e.Location;
                        completed = 2;
                    }
                    if (completed == 2)
                    {
                        Line line = new Line(start, end);
                        lines.Add(line);
                        completed = 0;
                    }
                }
                else if (rBtUseCase.Checked)
                {
                    string name = GetPopupValue();
                    UseCase ucs = new UseCase(e.Location, name);
                    usecase.Add(ucs);
                }
                else if (rBtActor.Checked)
                {
                    string name = GetPopupValue();
                    Actor act = new Actor(e.Location, name);
                    actors.Add(act);
                }
                
            }
            else if (rBtSelect.Checked)
            {
                foreach (UseCase ucs in usecase)
                {
                    if (ucs.selection == Selection.Selected)
                    {
                        ucs.selection = Selection.Normal;
                        btShow.Enabled = false;

                    }
                    if (ucs.selection != Selection.Selected)
                    {
                        Rectangle rect = new Rectangle(e.Location, ucs.size);
                        if (rect.Contains(ucs.location))
                        {
                            ucs.selection = Selection.Selected;
                            btShow.Enabled = true;
                        }
                    }
                    
                }
                foreach (Actor act in actors)
                {
                    if (act.selection == Selection.Selected)
                    {
                        act.selection = Selection.Normal;
                        btShow.Enabled = false;
                    }
                    if (act.selection != Selection.Selected)
                    {
                        Rectangle rect = new Rectangle(e.Location, act.size);
                        if (rect.Contains(act.location))
                        {
                            act.selection = Selection.Selected;
                            btShow.Enabled = false;
                        }
                    }
                }
            }
            
            pbUseCase.Refresh();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            usecase.Clear();
            actors.Clear();
            lines.Clear();
            pbUseCase.Refresh();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            foreach (UseCase ucs in usecase.ToList())
            {
                if (ucs.selection == Selection.Selected)
                {
                    usecase.Remove(ucs);
                }
            }
            foreach (Actor act in actors.ToList())
            {
                if (act.selection == Selection.Selected)
                {
                    actors.Remove(act);
                }                     
            }
            
            pbUseCase.Refresh();
        }

        private void pbUseCase_MouseMove(object sender, MouseEventArgs e)
        {
            if (rBtSelect.Checked)
            {

                foreach (UseCase ucs in usecase)
                {
                    if (ucs.selection != Selection.Selected)
                    {
                        ucs.selection = Selection.Normal;
                        Rectangle rect = new Rectangle(e.Location, ucs.size);
                        if (rect.Contains(ucs.location))
                        {
                            ucs.selection = Selection.Highlight;
                        }
                    }
                }
                foreach (Actor act in actors)
                {
                    if (act.selection != Selection.Selected)
                    {
                        act.selection = Selection.Normal;
                        Rectangle rect = new Rectangle(e.Location, act.size);
                        if (rect.Contains(act.location) && act.selection != Selection.Selected)
                        {
                            act.selection = Selection.Highlight;
                        }
                    }
                }
            }
            pbUseCase.Refresh();
        }

        private void pbUseCase_Paint(object sender, PaintEventArgs e)
        {
           
            foreach (UseCase ucs in usecase)
            {
                ucs.Draw(e.Graphics);
            }

            foreach (Actor actor in actors)
            {
                actor.Draw(e.Graphics);
            }

            foreach (Line line in lines)
            {
                line.Draw(e.Graphics);
            }
        
        }
        private string GetPopupValue()
        {
            Popup pp = new Popup();
            pp.ShowDialog();

            string name = pp.Word;

            if (pp.DialogResult == DialogResult.OK)
            {
                return name;
            }
            else
            {
                return "";
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            UseCase cs = null;
            Info info = new Info();

            foreach (UseCase ucs in usecase)
            {
                if (ucs.selection == Selection.Selected)
                {
                    cs = ucs;
                }
            }

            info.name = cs.name;
            info.summary = cs.summary;
            info.actors = cs.actors;
            info.assumptions = cs.assumptions;
            info.description = cs.description;
            info.exceptions = cs.exceptions;
            info.result = cs.result;

            info.UpdateForm();

            info.ShowDialog();

            if (info.DialogResult == DialogResult.OK)
            {
                cs.name = info.name;
                cs.summary = info.summary;
                cs.actors = info.actors;
                cs.assumptions = info.assumptions;
                cs.description = info.description;
                cs.exceptions = info.exceptions;
                cs.result = info.result;
            }

            pbUseCase.Refresh();
        }

        private void btClearLines_Click(object sender, EventArgs e)
        {
            lines.Clear();
            pbUseCase.Refresh();
        }
    }
}
