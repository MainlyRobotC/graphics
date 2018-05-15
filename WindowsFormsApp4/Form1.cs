using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics gfx;
        List<ball> balls = new List<ball>(40);
        Random rnd = new Random();

        public Color Backcolor { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = this.CreateGraphics();
            for(int i = 0; i < 5; i++)
            {
                balls.Add(new ball(rnd.Next(0,ClientSize.Width), rnd.Next(0,ClientSize.Height), rnd.Next(10,50), rnd.Next(10,50), 100, 100, rnd));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].draw(gfx,ClientSize);
            }
        }

        private void addBall_Click(object sender, EventArgs e)
        {
            balls.Add(new ball(rnd.Next(0, ClientSize.Width), rnd.Next(0, ClientSize.Height), rnd.Next(10, 50), rnd.Next(10, 50), 100, 100, rnd));
        }
    }
}
