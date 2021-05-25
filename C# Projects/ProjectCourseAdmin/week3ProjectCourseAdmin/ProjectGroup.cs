using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3ProjectCourseAdmin
{
    public class ProjectGroup
    {
        public string Name { set; get; }
        public List<Student> students { set; get; }

        public ProjectGroup(string _name)
        {
            Name = _name;
            students = new List<Student>();
        }
    }
}
