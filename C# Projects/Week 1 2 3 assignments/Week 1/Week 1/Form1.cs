using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Week_1
{
    public partial class Form1 : Form
    {
        School school;
        ISpeaker guestSpeaker;
        Robot robot;
        public Form1()
        {
            InitializeComponent();
            gBStudent.Visible = false;
            GbTeacher.Visible = false;
            school = new School("Fontys FHICT");
            AddData();
        }
        private void btnNewPerson_Click(object sender, EventArgs e)
        {
          
            bool isadded = false;
            if (rBStudent.Checked)
            {
                 isadded=school.AddPerson(new Student(int.Parse(tBAge.Text), TbName.Text, int.Parse(tbPCN.Text), int.Parse(tByrsat.Text), tBCountry.Text, int.Parse(tBECS.Text)));
            }
            else if (rBTeacher.Checked)
            {
                isadded=school.AddPerson(new Teacher(int.Parse(tBAge.Text), TbName.Text, int.Parse(tbPCN.Text), int.Parse(tByrsat.Text), function.juniorteacher, double.Parse(tBSalary.Text)));
            }
            if (!isadded)
            {
                MessageBox.Show("This pcn is already exists");
            }

        }
        private void ShowInfoperson(Person p)
        {
            lbOutput.Items.Add(p);
            
        }

        private void btnShowInfoPerson_Click(object sender, EventArgs e)
        {
            
            foreach (var p in school.GetPersons())
            {
                ShowInfoperson(p);
            }
           
        }
        private void CelebBirthday_Click(object sender, EventArgs e)
        {
            school.GetPerson(int.Parse(tBSelectedPCN.Text)).CelebrateBirthday();
        }

        private void StartAnotherSchoolyear_Click(object sender, EventArgs e)
        {
            school.GetPerson(int.Parse(tBSelectedPCN.Text)).StartAnotherSchoolyear();
        }
        private void rBPerson_CheckedChanged(object sender, EventArgs e)
        {
            gBStudent.Visible = false;
            GbTeacher.Visible = false;
        }

        private void rBStudent_CheckedChanged(object sender, EventArgs e)
        {
            gBStudent.Visible = true;
            GbTeacher.Visible = false;

        }


        private void rBTeacher_CheckedChanged(object sender, EventArgs e)
        {
            gBStudent.Visible = false;
            GbTeacher.Visible = true;
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            
            if (tbNameSearch.Text != "" && tbPCN.Text != "")
            {
                foreach (var p in school.GetPersons(tbNameSearch.Text))
                {
                    ShowInfoperson(p);
                }
            }
            else if (tBAgeYoung.Text != "")
            {
                foreach (var p in school.GetYoungPersons(int.Parse(tBAgeYoung.Text)))
                {
                    ShowInfoperson(p);
                }
            }

        }

        private void btnExtraInfo_Click(object sender, EventArgs e)
        {
            
            if (tbExtraPCN.Text != "")
            {
                
                MessageBox.Show(school.GetPerson(int.Parse(tbExtraPCN.Text)).GetExtraInfo());
            }
            else
            {
                MessageBox.Show("Please enter PCN number");
            }
            
        }

        private void AddECS_Click(object sender, EventArgs e)
        {
            Person selectedPerson = school.GetPerson(int.Parse(tBpcnSearch.Text));

            if (selectedPerson is Student)
            {
                ((Student)selectedPerson).AddCredit(int.Parse(tBAddECS.Text));
            }
            else
            {
                MessageBox.Show("Person should be student");
            }
        }
        public void AddData()
        {
            school.AddPerson(new Student(18, "Fadi", 104, 2, "Syria", 60));
            school.AddPerson(new Student(19, "Wondi", 105, 1, "Ethiopia", 27));
            school.AddPerson(new Student(28, "Delal", 106, 4, "Turkey", 155));
            school.AddPerson(new Student(20, "Mateusz", 107, 1, "Poland", 30));
            school.AddPerson(new Teacher(22, "Obaid", 108, 1, function.juniorteacher, 2000));
            school.AddPerson(new Teacher(22, "Kalina", 109, 2, function.teacher1, 2500));
            school.AddPerson(new Teacher(22, "Bert", 110, 4, function.teacher2, 3500));
            school.AddPerson(new Teacher(22, "Ralia", 111, 7, function.teacher3, 8000));
        }

        private void btnmakepromotion_Click(object sender, EventArgs e)
        {
            Person selectedPerson = school.GetPerson(int.Parse(tBpcnSearch.Text));

            if(selectedPerson is Teacher)
            {
                ((Teacher)selectedPerson).MakePromotion();
            }
            else
            {
                MessageBox.Show("Person should be teacher");
            }
        }

        private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (this.lbOutput.SelectedItem != null)
            {
               
                if (lbOutput.SelectedIndex > -1)
                {
                    Person selectedPerson = (Person)lbOutput.SelectedItem;
                    tBNameSelected.Text = selectedPerson.GetName();
                    tBSelectedPCN.Text = selectedPerson.GetPCN().ToString();
                    tBpcnSearch.Text = selectedPerson.GetPCN().ToString();
                    tbExtraPCN.Text = selectedPerson.GetPCN().ToString();
                    tbNameSearch.Text = selectedPerson.GetName().ToString();
                   
                }

            }
        }

        private void btnsetspeaker_Click(object sender, EventArgs e)
        {
            Person selectedPerson = school.GetPerson(int.Parse(tBpcnSearch.Text));

            if(selectedPerson is Student)
            {
                guestSpeaker = ((Student)selectedPerson);
            }
            if(selectedPerson is Teacher)
            {
                guestSpeaker = ((Teacher)selectedPerson);
            }

        }

        private void btnpresentspeaker_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guestSpeaker.GetStartOfSpeech());
        }

        private void btnRobotSpeaker_Click(object sender, EventArgs e)
        {
            robot = new Robot();

            guestSpeaker = robot;
            guestSpeaker = robot;
            guestSpeaker = robot;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter binaryF = null;
            SaveFileDialog saveDiaglog = new SaveFileDialog();
            

            if (saveDiaglog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDiaglog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    binaryF = new BinaryFormatter();

                    binaryF.Serialize(fs, school);
                }
                catch (IOException)
                {
                    MessageBox.Show("Eror saving file");
                }
                finally
                {
                    fs.Close();
                }
            }              
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    school = (School)bf.Deserialize(fs);
                    //Person person = (Person)bf.Deserialize(fs);
                    //MessageBox.Show(person.Name);
                }
                catch(IOException)
                {
                    MessageBox.Show("Error saving file");
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void btnGenerateOverview_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);


                    foreach (var loopPerson in school.GetPersons())
                    {
                        if (loopPerson.GetYears() == 1)
                        {
                            sw.WriteLine(loopPerson.ToString());
                            sw.WriteLine("**********************");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    sw.Close();
                }

            }
        }
    }

}
