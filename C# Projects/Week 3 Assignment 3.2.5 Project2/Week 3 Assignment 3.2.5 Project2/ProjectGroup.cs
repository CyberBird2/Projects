using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Assignment_3._2._5_Project2
{
    class ProjectGroup
    {
        private string ProjectGroupName;
        public List<Student> Studentss;

        public ProjectGroup(string _ProjectGroupName)
        {
            this.ProjectGroupName = _ProjectGroupName;
            Studentss = new List<Student>();
        }

    }
}
