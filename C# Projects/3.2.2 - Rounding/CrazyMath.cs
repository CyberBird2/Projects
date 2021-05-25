using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._2___Rounding
{
				class CrazyMath
				{
								private static Random r = new Random();

								private static bool shouldPreformAction()
								{
												return (r.NextDouble() >= 0.5);
								}

								public static double Round(double num, int decimals)
								{
												if (decimals > 0)
																num = num * Math.Pow(10, decimals);

												num = (shouldPreformAction() ? Math.Floor(num) : Math.Ceiling(num));

												if (decimals > 0)
																num = num / Math.Pow(10, decimals);

												return num;
								}
				}
}
