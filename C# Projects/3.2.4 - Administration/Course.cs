using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._4___Administration
{
				class Course
				{
								private List<Student> enrolledStudents;
								private int maxGroupSize = 3;
								private int groupCounter = 0;
								private List<string> groups;
								public static string name;

								public List<string> Groups
								{
												get { return groups; }
								}

								public Course(string _name)
								{
												name = _name;
												enrolledStudents = new List<Student>();
												groups = new List<string>() { generateNewGroupName() };
								} 

								public bool AddStudent(string name, int studentNumber)
								{
												if (!CheckStudentnumUnique(studentNumber))
																return false;

												if (groupCounter >= maxGroupSize)
												{
																groupCounter = 0;
																groups.Add(generateNewGroupName());
												}

												Student s = new Student(name, groups.Last(), studentNumber);
												
												if (s != null)
												{
																enrolledStudents.Add(s);
																groupCounter++;
																return true;
												} else
												{
																return false;
												}
								}

								private string generateNewGroupName()
								{
												return $"PG{((groups == null) ? 0 : groups.Count)}_{name}";
								}

								public Student[] AllStudents()
								{
												return enrolledStudents.ToArray();
								}

								public Student SearchByStudentnumber(int query)
								{
												foreach (Student s in enrolledStudents)
												{
																if (s.StudentNumber == query)
																				return s;
												}

												return null;
								}

								public Student[] SearchByGroup(string query)
								{
												List<Student> newList = new List<Student>();

												foreach (Student s in enrolledStudents)
												{
																if (s.GroupName.StartsWith(query))
																				newList.Add(s);
												}

												return newList.ToArray();
								}

								public int GetStudentCount()
								{
												return enrolledStudents.Count;
								}

								public int GetGroupCount()
								{
												return groups.Count;
								}

								private bool CheckStudentnumUnique(int num)
								{
												foreach (Student s in enrolledStudents)
												{
																if (s.StudentNumber == num)
																				return false;
												}

												return true;
								}
				}

				class Student
				{
								private int studentNumber;
								private string groupName;
								private string name;

								public string Name
								{
												get { return name; }
								}

								public int StudentNumber
								{
												get { return studentNumber; }
								}

								public string GroupName
								{
												get { return groupName; }
								}

								public Student(string name, string groupName, int studentNumber)
								{
												if (String.IsNullOrEmpty(name.Trim()))
																return;

												if (studentNumber > 10000 || studentNumber < 0)
																return;

												this.studentNumber = studentNumber;
												this.groupName = groupName;
												this.name = name;
								}

								public string GetInfo()
								{
												return $"{name} ({studentNumber}) - {groupName}";
								}
				}
}
