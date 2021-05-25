using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1___SortingGrades
{
				class AcademicResult : IComparable<AcademicResult>
				{
								private string studentName;
								private int studentNumber;
								private string course;
								private double grade;

								public string Course { get { return course; } }
								public double Grade { get { return grade; } }

								public AcademicResult(string studentName, int studentNumber, string course, double grade)
								{
												this.studentNumber = studentNumber;
												this.studentName = studentName;
												this.course = course;
												this.grade = grade;
								}

								public string GetStudent()
								{
												return $"{studentName} (student number {studentNumber})";
								}

								public string GetInfo()
								{
												return $"{course}: {GetStudent()} - {grade}";
								}

								public int CompareTo(AcademicResult other)
								{
												if (other == null)
																return 1;
												else
																return this.grade.CompareTo(other.grade);
								} 
				}
}
