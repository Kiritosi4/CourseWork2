using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal class CustomProgressBar : ProgressBar
    {
        Color _channelColor = Color.Gray;
        Color _sliderColor = Color.RoyalBlue;
        Color _textColor = Color.White;

        int _barHeight = 5;

        bool _paintBack;
        bool _stopPainting;

        public Color ChannelColor
        {
            get { return _channelColor; }
            set { _channelColor = value; this.Invalidate(); }
        }

        public Color SliderColor
        {
            get { return _sliderColor; }
            set { _sliderColor = value; this.Invalidate(); }
        }

        public int BarHeight
        {
            get { return _barHeight; }
            set { _barHeight = value; this.Invalidate(); }
        }

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }


        protected override void OnPaintBackground(PaintEventArgs args)
        {
            if (!_stopPainting)
            {
                if (!_paintBack)
                {
                    Graphics graphics = args.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, _barHeight);

                    using (SolidBrush brush = new SolidBrush(_channelColor))
                    {
                        //rectChannel.Y = _barHeight;

                        graphics.Clear(this.Parent.BackColor);
                        graphics.FillRectangle(brush, rectChannel);

                        if (!this.DesignMode)
                        {
                            _stopPainting = true;
                        }
                    }
                }

                if(this.Value == this.Maximum || this.Value == this.Minimum)
                {
                    _paintBack = false;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            if (!_stopPainting)
            {
                Graphics graphics = args.Graphics;
                float scale = ((float)this.Value - this.Minimum) / ((float)this.Maximum - this.Minimum);
                int width = (int)(this.Width * scale);

                Rectangle rectSlider = new Rectangle(0, 0, width, _barHeight);
                using (SolidBrush brush = new SolidBrush(_sliderColor))
                {
                    //rectSlider.Y = _barHeight;

                    if(width > 1) 
                    {
                        graphics.FillRectangle(brush, rectSlider);
                    }
                }
            }
        }
    }
}
