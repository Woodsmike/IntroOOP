using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class BadGuys
    {
        private string costumes;
        private string name;
        private string evilPowers;
        private int strengthLevel;

        public string Costumes { get; set; }
        public string Name { get; set; }
        public string EvilPowers { get; set; }
        public int StrengthLevel { get; set; }

        public BadGuys()
        {
            Random random = new Random();
            //default constructor
            this.costumes = "a bed sheet";
            this.name = "A really bad dude.";
            this.evilPowers = "I can control empty boxes";
            this.strengthLevel = random.Next(0, 51);
        }
        public BadGuys(string name, string costumes, int strengthLevel)
        {
            this.name = name;
            this.costumes = costumes;
            this.evilPowers = GetPowers();
            this.strengthLevel = strengthLevel;
        }
        public string GetPowers()
        {
            string[] powers = {"Killer Farts", "Mind Control","Throwing fire",
            "Words that can kill","Evil laugh"};
            Random random = new Random();
            string newPower = powers[random.Next(0, powers.Length)];
            return newPower;
        }
    }
}
