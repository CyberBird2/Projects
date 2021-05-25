using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraFarm
{
				public class ZebraFarm {
								private List<Zebra> zebras;
								private string name;

								public ZebraFarm(string name)
								{
												zebras = new List<Zebra> {
																new Zebra("Berta1", Gender.MARE),
																new Zebra("Henk1", Gender.STALLION)
												};

												if (String.IsNullOrEmpty(name.Trim()))
																this.name = "Unknown";
												else
																this.name = name;
								}

								public Zebra GetZebra(int id)
								{
												foreach (Zebra z in zebras)
												{
																if (z.GetId() == id)
																				return z;
												}

												return null;
								}

								public Zebra[] GetZebras()
								{
												return zebras.ToArray();
								}

								public Zebra[] GetZebras(Gender g)
								{
												List<Zebra> found = new List<Zebra>();

												foreach (Zebra z in zebras) {
																if (z.Gender == g)
																				found.Add(z);
												}

												return found.ToArray();
								}

								public bool AttemptToBreed(int motherId, int fatherId)
								{
												Zebra mother = GetZebra(motherId);
												Zebra father = GetZebra(fatherId);

												if (mother != null && father != null)
												{
																Zebra baby = mother.AttemptToProduceOffpring(father);

																if (baby == null)
																				return false;
																else
																{
																				zebras.Add(baby);
																				return true;
																}
												} else
												{
																throw new Exception("Invalid Zebra id");
												}
								}
				}
}
