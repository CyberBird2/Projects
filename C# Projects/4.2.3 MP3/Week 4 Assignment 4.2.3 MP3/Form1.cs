using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4_Assignment_4._2._3_MP3
{
    public partial class Form1 : Form
    {
        List<song> SongList = new List<song>();
        status durum = status.stopped;
        int SongIndex = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SongList.Add(new song() { duration = 41, name = "Bohemian Rapshody", singer = "fredi" });
            SongList.Add(new song() { duration = 212, name = "Thriller", singer = "maykıl" });
            SongList.Add(new song() { duration = 43, name = "Thriller", singer = "fredi" });
            SongList.Add(new song() { duration = 432, name = "Adımız miskindir bizim", singer = "Mazhar Fuat" });

            //song aa = SongList.Where(x => x.singer == "fredi").FirstOrDefault();
            //List<song> songs = SongList.Where(x => x.singer == "fredi").ToList();
            //List<song> songs2 = SongList.Where(x => x.singer == "fredi" && x.duration==43).ToList();
            //List<song> songs3 = SongList.Where(x => x.singer == "fredi" || x.duration == 43).ToList();

            foreach (song sng in SongList)
            {
                lstSongs.Items.Add(sng.name + "-" + sng.singer);
            }

            lstSongs.SelectedIndex = 0;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {



            if (durum == status.playing)
            {
                durum = status.paused;
                txtStatus.Text = "Paused";
            }
            else
            {
                play();
                durum = status.playing;
                txtStatus.Text = "Playing";

                //prgSong.Maximum = selectedSong.duration;
                //for (int i = 0; i < selectedSong.duration; i++)
                //{
                //    prgSong.Value = i;
                //}
            }

        }

        public void play()
        {
            string songname = ((string)lstSongs.Items[SongIndex]).Split('-')[0];
            string singername = ((string)lstSongs.Items[SongIndex]).Split('-')[1];
            song selectedSong = SongList.Where(x => x.name == songname && x.singer == singername).FirstOrDefault();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            durum = status.stopped;
            txtStatus.Text = "Stopped";
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongIndex = lstSongs.SelectedIndex;
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            if (SongIndex > 0)
            {
                SongIndex = SongIndex - 1;               
            }
            else
            {
                SongIndex = 0;              
            }

            lstSongs.SelectedIndex = SongIndex;
            play();
            durum = status.playing;
            txtStatus.Text = "Playing";

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int maxCount = lstSongs.Items.Count-1;
            if (SongIndex==maxCount)
            {
                SongIndex = 0;             
            }
            else
            {
                SongIndex = SongIndex + 1;
            }
            lstSongs.SelectedIndex = SongIndex;
            play();
            durum = status.playing;
            txtStatus.Text = "Playing";
        }
    }
}
