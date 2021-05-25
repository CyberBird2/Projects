using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._5
{
				public partial class Form1 : Form
				{
								Font housenumberFont;

							    public Form1()
								{
												InitializeComponent();
												housenumberFont = new Font("Arial", 7);
												btnUpdate_Click(null, null);
								}

								private void btnUpdate_Click(object sender, EventArgs e)
								{
												pbMain.Invalidate();
								}

								private void pbMain_Paint(object sender, PaintEventArgs e)
								{
												int centerY = pbMain.Height / 2;
												int centerX = pbMain.Width / 2;

												int boxHeight = pbMain.Height / 2; // 2/4
												int boxWidth = pbMain.Width / 2;

												int roofWidth = pbMain.Width / 2 + (50 * 2);
												int roofHeight = pbMain.Height / 4;

												int doorHeight = boxHeight / 2;
												int doorWidth = 50;

												Graphics g = e.Graphics;
												// Background
												g.FillRectangle(Brushes.SkyBlue, 0, 0, pbMain.Width, pbMain.Height);

												g.FillRectangle(Brushes.White, centerX - boxWidth / 2, pbMain.Height - 1 - boxHeight, boxWidth, boxHeight);
												g.FillRectangle(Brushes.Black, (centerX + boxWidth / 2) - doorWidth - 10, pbMain.Height - doorHeight, doorWidth, doorHeight);
												g.FillPolygon(Brushes.Gray, genTrianglePoints(centerX - roofWidth / 2, centerX + roofWidth / 2, pbMain.Height - boxHeight, roofHeight));
            
                                          g.DrawString(tbHousenumber.Text, housenumberFont, Brushes.Black, (centerX + boxWidth / 2) - doorWidth - 10 - 30, pbMain.Height - doorHeight + 10);
								}

								private Point[] genTrianglePoints(int startX, int endX, int yPos, int height)
								{
												return new Point[] { new Point(startX, yPos), new Point((endX + startX) / 2, yPos - height), new Point(endX, yPos) };
								}
				}
}
