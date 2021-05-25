using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4._2._4___NewLanguage
{
				class Test
				{
								private Question[] questions;
								private bool[] answerResults;
								private string language;

								public Test(string lang, Question[] questions)
								{
												this.questions = questions;
												this.language = lang;
								}

								public string[] GetQuestions()
								{
												string[] quest = new string[questions.Length];

												for (int i = 0; i < questions.Length; i++)
																quest[i] = questions[i].question;

												return quest;
								}

								public bool[] CheckAnswers(string[] answers)
								{
												answerResults = new bool[questions.Length];

												for (int i = 0; i < questions.Length; i++)
																answerResults[i] = questions[i].CheckAnswer(answers[i]);

												return answerResults;
								}

								public string GetResults()
								{
												if (answerResults != null) {
																int correctAnswerCount = 0;
																string outputStr = "";

																for (int i = 0; i < answerResults.Length; i++)
																{
																				if (answerResults[i])
																								correctAnswerCount++;
																				else
																								outputStr += questions[i].GetInfo() + "\r\n";
																}

																if (correctAnswerCount < answerResults.Length)
																				outputStr = "\r\nThe correct answers should be as follows:\r\n" + outputStr;

																return $"You have answered {correctAnswerCount} out of {answerResults.Length} correctly." + outputStr;
												} else
												{
																throw new Exception("Answers aren't given!");
												}
								}
				}

				class Question
				{
								private string correctAnswer;
								private Regex regex;

								public string question { get; private set; }

								public Question(string question, string answer, string regex)
								{
												this.regex = new Regex(regex, RegexOptions.IgnoreCase);
												this.correctAnswer = answer;
												this.question = question;
								}

								public bool CheckAnswer(string input)
								{
												// Remove trailing dot
												input = Regex.Replace(input, @"\.$", "");
												return regex.IsMatch(input);
								}

								public string GetInfo()
								{
												return $"'{question}' = '{correctAnswer}'";
								}
				}
}
