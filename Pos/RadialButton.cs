using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class RadialButton : UserControl
    {
        public delegate void MyRadialClick(object sender, RadialClickEventArgs e);
        public event MyRadialClick RadialClick;
        bool isClicked = false;
        Pen myPen;
        public bool isPlus {  get; set; }
        public RadialButton()
        {
            InitializeComponent();
            myPen = new Pen(Color.Black, 1);
        }

        private void RadialButton_Paint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;
            gr.DrawEllipse(myPen, 0, 0, this.Width, this.Width);
            gr.DrawLine(myPen, this.Width / 4, this.Height / 2, this.Width * 3 / 4, this.Height / 2);
            if (isPlus)
            {
                gr.DrawLine(myPen, this.Width / 2, this.Height / 4, this.Width / 2, this.Height * 3 / 4);
            }
        }
        private void RadialButton_MouseClick(object sender, MouseEventArgs e)
        {
            float centerX = this.Width / 2;
            float centerY = this.Width / 2;
            float radius = this.Width / 2;

            float distance = (float)Math.Sqrt(Math.Pow(e.X - centerX, 2) + Math.Pow(e.Y - centerY, 2));

            if (distance <= radius)
            {
                isClicked = true;
                this.Invalidate();
                RadialClick?.Invoke(this, new RadialClickEventArgs(isPlus));
            }
        }
    }


}
