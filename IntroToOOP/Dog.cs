using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //your dog class should have fields for hair length, height, running speed,
        //and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle
        public Dog()
        {

        }
        public Dog(string hairLength, int runningSpeed, bool crap)
        {
            this.hairLength = hairLength;
            this.runningSpeed = runningSpeed;
            this.crap = crap;

        }

        private string hairLength;
        private string height;
        private double runningSpeed;
        private double weight;
        private bool bark = true;
        private bool crap = true;
        private bool cuddle = true;
        
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public string Height { get; set; }
        public double RunningSpeed { get; set; }
        public double Weight { get; set; }
        public bool Bark { get; set; }
        public bool Crap { get; set; }
        public bool Cuddle { get; set; }

        public void Run()
        {
            if (runningSpeed <= 1 )
            {
                Console.WriteLine("It is slow!");
            }
            else if (runningSpeed > 1 && runningSpeed >= 5 )
            {
                Console.WriteLine("It has average speed");
            }
            else
            {
                Console.WriteLine("It is way fast!");
            }
        }
        public void Barks()
        {
            if(bark == true)
            {
                Console.WriteLine("Your dog barks");
            }
        }
        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("Your dog just soiled your carpet!");
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself");
            }
        }
        public void Cuddles()
        {
            if (cuddle == true)
            {
                Console.WriteLine("Your dog wants to spoon you!");
            }
        }
    }
}
