using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_1
{
    [Serializable]
    class School
    {
        public string name;
        public List<Person> school;
        public School(string name)
        {
            this.name = name;
            this.school = new List<Person>();
        }
        public Person GetPerson(int pcn)
        {
            foreach (Person selectedpcn in school)
            {
                if (selectedpcn.PCN==pcn)
                {
                    return selectedpcn;
                }
            }
            return null;
            
        }
        public bool AddPerson(Person p)
        {

            foreach (Person selectedperson in school)
            {
                if (selectedperson.PCN == p.PCN)
                {
                    return false;
                }
                
            }
            school.Add(p);
            return true;
        }
        public List<Person> GetPersons()
        {
            return this.school;
        }
        public List<Person> GetPersons(string p)
        {
            List<Person> templistperson = new List<Person>();
            foreach (Person chosenperson in school)
            {
                if (chosenperson.Name.Contains(p))
                {
                    templistperson.Add(chosenperson);
                }
            }
            return templistperson;
        }
        public List<Person> GetYoungPersons(int limit)
        {
            List<Person> templistpersonyoung = new List<Person>();
            foreach (Person youngage in school)
            {
                if(youngage.AGE <= limit)
                {
                    templistpersonyoung.Add(youngage);
                }
            }
            return templistpersonyoung;
        }
    }
}
