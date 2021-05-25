using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4._2_Marks_Analyzer
{
    class Student
    {
        private string name;
        private int Stnumber;

        private List<int> marks;


        public Student(string name,int Stnumber) 
        {
            this.name = name;
            this.Stnumber = Stnumber;

            marks = new List<int>();
        }
        public void AddMark(int mark)
        {
            marks.Add(mark);
        }
        public int CalculateAverageMark()
        {
            int sum = 0;

            foreach (int chosenmark in marks)
            {
                sum = sum + chosenmark;
            }
            return sum / marks.Count;

        }


    }
}
