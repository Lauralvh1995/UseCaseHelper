using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case
{
    class Line
    {
        public Point location1 { get; set; }
        public Point location2 { get; set; }
        public Size size { get; set; }
        public Selection selection { get; set; }
        public SolidBrush brush { get; set; }

        public Line(Point location1, Point location2)
        {
            this.location1 = location1;
            this.location2 = location2;
            this.selection = Selection.Normal;
            this.brush = new SolidBrush(Color.Black);
            this.size = new Size();
        }

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

            g.DrawLine(pen, location1, location2);
            
            this.size = new Size((int)size.Width + 20, (int)size.Height + 10);
        }
    }
}
