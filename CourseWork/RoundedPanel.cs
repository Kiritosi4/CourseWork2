using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public class RoundedPanel : Panel
    {
        int _borderRadius = 10;

        public RoundedPanel()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Size = new Size(250, 250);
        }

        public int BorderRadius 
        { 
            get => _borderRadius; 
            set { _borderRadius = value; this.Invalidate(); } 
        }

        GraphicsPath GetGraphicsPath(RectangleF rectAngle, float radius)
        {   
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectAngle.Width - radius, rectAngle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectAngle.X, rectAngle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectAngle.X, rectAngle.Y, radius, radius, 180, 90);
            path.AddArc(rectAngle.Width - radius, rectAngle.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(this.BackColor);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (_borderRadius > 2)
            {
                using(GraphicsPath path = GetGraphicsPath(rectangleF, _borderRadius))
                using(Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }
    }
}
