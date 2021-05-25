using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_4._2._3_MP3
{
    public class song
    {
        public string name { get; set; }

        public int duration { get; set; }

        public string singer { get; set; }
    }

    public enum status
    {
        playing=0,
        paused = 1,
        stopped =2
       


    }



}
