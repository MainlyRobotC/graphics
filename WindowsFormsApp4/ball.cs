using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ball
    {
        public int x;
        public int y;
        public int speedx;
        public int speedy;
        public int red = 0;
        public int green = 0;
        public int blue = 0;
        public float width;
        public float height;
        Random rnd;

        public ball(int x, int y, int speedx, int speedy, float width, float height, Random rnd)
        {
            this.x = x;
            this.y = y;
            this.speedx = speedx;
            this.speedy = speedy;
            this.width = width;
            this.height = height;
            this.rnd = rnd;
        }

        public void draw(Graphics gfx, Size ClientSize)
        {


            x += speedx;
            y += speedy;

            red = rnd.Next(0, 255);
            green = rnd.Next(0, 255);
            blue = rnd.Next(0, 255);

            width -= 0.25f;
            height -= 0.25f;

            gfx.FillEllipse(new SolidBrush(Color.FromArgb(red, green, blue)), x, y, width, height);

            if (ClientSize.Height <= y + height)
            {
                speedy = -(Math.Abs(speedy));
            }
            else if (ClientSize.Width <= x + width)
            {
                speedx = -(Math.Abs(speedx));
            }
            else if (x < 0)
            {
                speedx = (Math.Abs(speedx));
            }
            else if (y < 0)
            {
                speedy = (Math.Abs(speedy));
            }
        }
    }
}
