using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Week_1
{
    [Serializable]
    public class Teacher:Person
    {
        private function function;
        private double salary;

        public Teacher(int age, string name, int pcn, int yearsatschool,function Function,double salary) : base(age, name, pcn, yearsatschool)
        {
            this.function = Function;
            this.salary = salary;
        }

        public override string AsString()
        {
            return base.AsString()+" | function: "+this.function+" | salary: "+this.salary;
        }

        public override string GetExtraInfo()
        {
           return  " | function: " + this.function + " | salary: " + this.salary;
        }

        public override string GetStartOfSpeech()
        {
            return "Hello everybody, my name is " + this.Name + " and I will talk about";
        }

        public void MakePromotion()
        {
            if(function!= function.director)
            {
                function++;
            }
        }
        public override void StartAnotherSchoolyear()
        {
            base.StartAnotherSchoolyear();
            if (base.GetYears() % 3 == 0)
            {
                salary = salary * 1.1;

            }
        }
    }
}
