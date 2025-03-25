using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Media
{
    internal class CircularProgressBar: Control
    {
        private int _progress = 0;
        public int Progress
        {
            get { return _progress; }
            set { _progress = Math.Max(0, Math.Min(100, value)); Invalidate(); }
        }

        public CircularProgressBar()
        {
            this.Size = new Size(100, 100);
            this.DoubleBuffered = true; // Giúp giảm flicker
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int width = this.Width - 10;
            int height = this.Height - 10;
            Rectangle rect = new Rectangle(5, 5, width, height);

            using (Pen penBackground = new Pen(Color.LightGray, 10))
            {
                g.DrawArc(penBackground, rect, 0, 360);
            }

            using (Pen penProgress = new Pen(Color.DarkOrange, 10))
            {
                g.DrawArc(penProgress, rect, -90, (int)(360 * _progress / 100.0));
            }

            using (Font font = new Font("Arial", 14, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                string text = _progress + "%";
                SizeF textSize = g.MeasureString(text, font);
                g.DrawString(text, font, brush, (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
            }
        }
    }
}
