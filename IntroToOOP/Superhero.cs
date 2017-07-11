using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //4 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        //4 properties
        
        public string Costume
        {
            get { return this.costume;  }
            set { this.costume = value; }

        }
        public string Name
        {
            get { return this.costume; }
        }
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        //3 constructors

        public Superhero()
        {
            //this is the default constructor
        }
        public Superhero(string name)
        {
            this.name = name;
            this.StrengthLevel = 100;
        }
        public Superhero(string name, string costume, int strengthLevel, string power, bool hasCape)
        {
            this.name = name;
            this.costume = costume;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }

        //2 methods
        public void BattleNemesis()
        {
            this.StrengthLevel -= 10;
            this.HasCape = false;
            this.costume = "Tattered";
        }
        public void AllyGained()
        {
            this.StrengthLevel += 10;
            this.HasCape = false;
            Console.WriteLine("Thank you for being my friend.");
        }
    }
}
