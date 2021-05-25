using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._4___Painting
{
				public partial class Form1 : Form
				{
								private const double PI = Math.PI;
								private int adder;
								private float x;

								public Form1()
								{
												InitializeComponent();
												adder = 1;
								}

								private void btnToggle_Click(object sender, EventArgs e)
								{
											
																timerPainter.Start();
								}

								private void timerPainter_Tick(object sender, EventArgs e)
								{
												if (x + pbMain.Height - 1 >= pbMain.Width)
																adder = -1;
												else if (x <= 0)
																adder = 1;

												x += (adder * 2 * SineEaseInOut((x + pbMain.Height - 1) / pbMain.Width));
												pbMain.Invalidate();
								}

								private void pbMain_Paint(object sender, PaintEventArgs e)
								{
												PictureBox pb = (PictureBox)sender;
												Graphics g = e.Graphics;

												g.FillRectangle(Brushes.Cyan, x, 0, pb.Height - 1, pb.Height - 1);
								}

								private static float SineEaseInOut(float p)
								{
												return 0.5f * (1 - (float)Math.Cos(p * PI));
								}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}