using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1___SortingGrades
{
				class Administration
				{
								private List<AcademicResult> results;

								public Administration()
								{
												results = new List<AcademicResult>();

												results.Add(new AcademicResult("John Doe", 123456, "PCS1", 8.5));
												results.Add(new AcademicResult("John Doe", 123456, "PCS2", 5.6));
												results.Add(new AcademicResult("John Doe", 123456, "EDB1", 5.6));
												results.Add(new AcademicResult("Jane Doe", 134679, "PCS1", 7.5));
												results.Add(new AcademicResult("Alice Jansen", 654321, "EDB1", 9.5));
												results.Add(new AcademicResult("Alice Jansen", 654321, "PCS1", 9.6));
								}

								public AcademicResult[] GetResults()
								{
												return results.ToArray();
								}

								public void SortByGrade()
								{
												results.Sort();
								}

								public AcademicResult[] GetResults(string course)
								{
												List<AcademicResult> outp = new List<AcademicResult>();

												foreach (AcademicResult r in results)
												{
																if (r.Course == course)
																				outp.Add(r);
												}

												return outp.ToArray();
								}

								public string[] GetResultsStrings(string course)
								{
												List<string> outp = new List<string>();

												foreach (AcademicResult r in results)
												{
																if (r.Course == course)
                                                                {
                                                                outp.Add(r.GetInfo()); 
                                                                }
                                                }

												return outp.ToArray();
								}

								public void RandomizeResults()
								{
												// https://stackoverflow.com/questions/273313/randomize-a-listt
												Random r = new Random();

												int n = results.Count;
												while (n > 1)
												{
																n--;
																int k = r.Next(n + 1);
																AcademicResult value = results[k];
																results[k] = results[n];
																results[n] = value;
												}
								}

								public AcademicResult GetByIndex(int index)
								{
												return results[index];
								}

								public string[] GetCourseNames()
								{
												List<string> courses = new List<string>();

												foreach (AcademicResult r in results)
												{
																if (!courses.Contains(r.Course))
																				courses.Add(r.Course);
												}

												return courses.ToArray();
								}
				}

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
