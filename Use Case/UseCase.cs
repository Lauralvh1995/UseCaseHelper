using System.Collections.Generic;
using System.Drawing;

namespace Use_Case
{
    class UseCase 
    {
        public Point location { get; set; }
        public Size size { get; set; }
//        public Selection selection { get; set; }

        public SolidBrush brush { get; set; }
        public Font font { get; set; }

        public string name { get; set; }
        public string summary { get; set; }
        public List<Actor> actors { get; set; }
        public string assumptions { get; set; }
        public string description { get; set; }
        public string exceptions { get; set; }
        public string result { get; set; }

        public UseCase(Point location /*string name*/ )
        {
            this.location = location;
 //           this.name = name;
 //           this.selection = Selection.Normal;

            this.brush = new SolidBrush(Color.Black);
            this.font = new Font("Arial", 10);
            this.summary = "";
            this.actors = new List<Actor>();
            this.assumptions = "";
            this.description = "";
            this.exceptions = "";
            this.result = "";
            this.size = new Size();
        }

        public void Draw(Graphics g)
        {
           /* switch (selection)
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
            }*/

            Pen pen = new Pen(brush);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            SizeF size = g.MeasureString(name, font);

            g.FillEllipse(new SolidBrush(Color.White), location.X - (size.Width / 2) - 10, location.Y - (size.Height / 2) - 5, size.Width + 20, size.Height + 10);
            g.DrawEllipse(pen, location.X - (size.Width / 2) - 10, location.Y - (size.Height / 2) - 5, size.Width + 20, size.Height + 10);
            g.DrawString(name, font, brush, location.X, location.Y - (size.Height / 2), format);

            this.size = new Size((int)size.Width + 20, (int)size.Height + 10);
        }
    }
}