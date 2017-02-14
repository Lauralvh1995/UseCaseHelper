using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case
{
    class Actor
    {
        //Fields
        public Point location { get; set; }
        public Size size { get; set; }
        public Selection selection { get; set; }

        public SolidBrush brush { get; set; }
        public Font font { get; set; }
        public string name { get; set; }
        public string summary { get; set; }

        //Constructor
        public Actor(Point location, string name)
        {
            this.location = location;
            this.name = name;
            this.selection = Selection.Normal;
            this.brush = new SolidBrush(Color.Black);
            this.font = new Font("Arial", 10);
            this.summary = "";
            this.size = new Size();
        }

        //Methods
        public void Draw(Graphics g)
        {
            switch (selection)
            {
                case Selection.Normal:
                    brush.Color = Color.Black;
                    break;
                case Selection.Highlight:
                    brush.Color = Color.Orange;
                    break;
                case Selection.Selected:
                    brush.Color = Color.Red;
                    break;
                default:
                    brush.Color = Color.Black;
                    break;
            }

            Pen pen = new Pen(brush);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            SizeF size = g.MeasureString(name, font);

            g.FillEllipse(new SolidBrush(Color.White), location.X - 20, location.Y - 20, 20, 20);
            g.DrawEllipse(pen, location.X - 20, location.Y - 20, 20, 20);
            g.DrawString(name, font, brush, location.X - 10, location.Y - (size.Height / 2) + 55, format);
            g.DrawLine(pen, location.X - 10, location.Y, location.X -10, location.Y + 25);
            g.DrawLine(pen, location.X - 20, location.Y + 10, location.X, location.Y + 10);
            g.DrawLine(pen, location.X - 10, location.Y  + 25, location.X  - 20, location.Y + 45);
            g.DrawLine(pen, location.X - 10, location.Y  + 25, location.X, location.Y + 45);

            this.size = new Size((int)size.Width + 20, (int)size.Height + 10);
        }
    }
}
