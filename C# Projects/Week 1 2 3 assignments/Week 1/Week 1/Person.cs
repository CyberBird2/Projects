using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_1
{
    [Serializable]
    public abstract class Person:ISpeaker
    {

        private int age;
        private string name;
        private int pcn;
        private int yearsAtSchool;

        public int PCN { get { return this.pcn; }  }
        public string Name { get { return this.name; } }

        public int AGE { get { return this.age; } }


        public Person(int age,string name,int pcn,int yearsatschool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsatschool;
        }

        public virtual string AsString()
        {
            string info;
            info = " Name: " + this.name + " | age: " + this.age + " | pcn: " + this.pcn + " | years at school: " + this.yearsAtSchool;
            return info;

        }
        public int GetYears()
        {
            return this.yearsAtSchool;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetPCN()
        {
            return this.pcn;
        }
        public int GetAge()
        {
            return this.age;
        }

        public void CelebrateBirthday()
        {
            this.age++;
        }
        public virtual void StartAnotherSchoolyear()
        {
            this.yearsAtSchool++;
        }
        public abstract string GetExtraInfo();

        public abstract string GetStartOfSpeech();
    }
}
