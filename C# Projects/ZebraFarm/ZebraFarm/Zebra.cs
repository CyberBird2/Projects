using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZebraFarm
{
				public enum Gender
				{
								STALLION,
								MARE,
								UNKNOWN
				}

				public class Zebra
				{
								// Instance variables
								private Regex nameRegex = new Regex(@"^([A-Z]([A-Za-z]+|\-+|\d+)+)$");
								private static int idSeeder = 12345;

								private int motherId;
								private int fatherId;
								private string name;
								private int id;

								private Random r;

								// Properties
								public Gender Gender { get; set; }
								public string Name {
												get
												{
																return name;
												}
												set
												{
																if (nameRegex.IsMatch(value))
																				name = value;
																else
																				name = "No-Name0";
												}
								}

								// Constructors
								public Zebra(string name, Gender gender)
								{
												r = new Random();

												this.Gender = gender;
												this.id = idSeeder;
												this.motherId = -1;
												this.fatherId = -1;
												this.Name = name;

												idSeeder++;
								}

								public Zebra(string name, Gender gender, int motherId, int fatherId)
								{
												r = new Random();

												this.motherId = motherId;
												this.fatherId = fatherId;
												this.Gender = gender;
												this.id = idSeeder;
												this.Name = name;

												idSeeder++;
								}

								// Methods
								public Zebra AttemptToProduceOffpring(Zebra mate)
								{
												if (this.Gender == Gender.MARE && mate.Gender == Gender.STALLION)
												{
																string name = $"{this.name}-with-{mate.name}";
																int randomVal = r.Next(0, 100);

																if (randomVal < 45)
																				return new Zebra(name, Gender.MARE, this.id, mate.id);
																else if (randomVal >= 45 && randomVal < 45 * 2)
																				return new Zebra(name, Gender.STALLION, this.id, mate.id);
												}

												return null;
								}
        
        public string GetInfo()
        {
            string s = this.Name + "(id " + this.id.ToString() + ") is a " + this.Gender.ToString();
            if (this.motherId > -1 )
            { s += "; motherId " + this.motherId; }
            if(this.fatherId > -1)
            { s += "; fatherId " + this.fatherId; }
            return s;
        }

								public int GetId()
								{
												return id;
								}

								public override string ToString()
								{
												return GetInfo();
								}
    }
}
