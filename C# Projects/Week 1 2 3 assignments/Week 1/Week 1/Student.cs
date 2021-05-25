using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_1
{
    [Serializable]
    public class Student:Person
    {
        private string country;
        private int nrOfECS;


        public Student(int age, string name, int pcn, int yearsatschool,string country,int nrofecs) : base(age, name, pcn, yearsatschool)
        {
            this.country = country;
            this.nrOfECS = nrofecs;
        }
        public override string AsString()
        {
            return base.AsString() + " | Country: " + this.country + " | NrOfEcs: " + this.nrOfECS;
        }

        public override string GetExtraInfo()
        {
            return  " | Country: " + this.country + " | NrOfEcs: " + this.nrOfECS;
        }

        public void AddCredit(int n)
        {
            this.nrOfECS += nrOfECS;

        }

        public override string GetStartOfSpeech()
        {
            return "Hello sunshines! " + this.Name + " is my name and today it is about …";
        }
    }
}
