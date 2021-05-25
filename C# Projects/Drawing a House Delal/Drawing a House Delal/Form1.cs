using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_a_House_Delal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pBHouse_Paint(object sender, PaintEventArgs e)
        {
            //Center of the house
            int centerY = pBHouse.Height / 2;
            int centerX = pBHouse.Width / 2;
            //House
            int boxHeight = pBHouse.Height / 2;
            int boxWidht = pBHouse.Width / 2;

            int roofWidth = pBHouse.Width / 2 + (50 * 2);
            int roofHeight = pBHouse.Height / 4;

            int doorHeight = boxHeight / 2;
            int doorWidth = 50;
            
            Graphics g = e.Graphics;

            
            //Background
            g.FillRectangle(Brushes.SkyBlue, 0, 0, pBHouse.Width, pBHouse.Height);
            // House               brushes              int x                  int y                   int width    int height
            g.FillRectangle(Brushes.White, centerX - boxWidht / 2, pBHouse.Height - 1 - boxHeight, boxWidht, boxHeight);
            ////Door             brushes               int x                                      int y             int width   int height
            g.FillRectangle(Brushes.Yellow, (centerX + boxWidht / 6) - doorWidth - 10, pBHouse.Height - doorHeight, doorWidth, doorHeight);
            //Roof          Brushes         int startx                             int endx                       int ypos               int height
            g.FillPolygon(Brushes.Gray, genTrianglePoints(centerX - roofWidth / 2, centerX + roofWidth / 2, pBHouse.Height - boxHeight, roofHeight));
            //FillPolygon has 2 overloads( Brusshes,Point [])
             Point[] genTrianglePoints(int startX, int endX, int yPos, int height)
            {
                return new Point[] { new Point(startX, yPos), new Point((endX + startX) / 2, yPos - height), new Point(endX, yPos) };
            }
        }

        private void pBHouse_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
