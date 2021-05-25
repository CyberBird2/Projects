using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4._2._1___Regex
{
				class RegexPlayground
				{
								private static string phoneNumRegex = @"^(06(\d+|\s+)+)$";
								private static string dutchPhoneNumRegex = @"^(\+31\d{9})$";
								private static string streetNameRegex = @"^(([A-Z]+|[a-z])+|\s+|\.)+$";
								private static string addressRegex = @"^((\w+|\s+|\.)+)(\d+)(\w+)?$";

								public static bool ValidPhoneNumber(string phoneNumber)
								{
												return Regex.IsMatch(phoneNumber, phoneNumRegex);
								}

								public static bool ValidDutchPhoneNumber(string phoneNumber)
								{
												return Regex.IsMatch(phoneNumber, dutchPhoneNumRegex);
								}

								public static bool ValidStreetName(string street)
								{
												return Regex.IsMatch(street, streetNameRegex);
								}

								public static bool ValidAddress(string address)
								{
												return Regex.IsMatch(address, addressRegex);
								}

								public static int RegexCount(string inp, string regex)
								{
												MatchCollection matches = Regex.Matches(inp, regex);
												int matchCount = 0;

												foreach (Match m in matches)
																matchCount += m.Groups.Count;

												return matchCount;
								}
				}
}
