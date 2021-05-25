using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsLizzardSpock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbPaper_Click(object sender, EventArgs e)
        {
            lbResults.Items.Add(game.kagit);
            Random rnd = new Random();
            int num=rnd.Next(0,3);
            lbResults.Items.Add((game)num);

            if (game.kagit>(game)num)
            {
                lbResults.Items.Add("---Win---");
            }
            if (game.kagit == (game)num)
            {
                lbResults.Items.Add("---Equal---");
            }
            if (game.kagit < (game)num)
            {
                lbResults.Items.Add("---Loose---");
            }


        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            lbResults.Items.Add(game.tas);
            Random rnd = new Random();
            int num = rnd.Next(0,2);
            lbResults.Items.Add((game)num);

            
        }

        private void pbScissors_Click(object sender, EventArgs e)
        {
            lbResults.Items.Add(game.makas);
            Random rnd = new Random();
            int num = rnd.Next(0, 2);
            lbResults.Items.Add((game)num);

        }

        //public void search(isActive aa)
        //{
        //    if (aa==isActive.all)
        //    {
                
        //    }
        //}

        //public void search(int aa)
        //{
        //    if (aa == 0)
        //    {

        //    }
        //}


        //public enum isActive
        //{
        //    all = 0,
        //    onlyActive = 1,
        //    onlyPassive = 2
        //}


        public enum game
        {
            tas=0,
            kagit=1,
            makas=2


        }

       
    }
}
