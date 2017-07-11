using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called instantiating 
            //creating a new instance of that object.
            //An object needs to be instantiated before it can be used.
            //All objects of a specific type are created from the same template - CLASS
            //All objects from a class will have the same number and type of states,
            //But each instance can have it's own unique values.

            //format we use to instantiate an object is:
            //ClassName objectName = new ClassName();
            /*Random rName = new Random();
            Cat mittens = new Cat();
            mittens.Name = "Mittens";

            Cat secondCat = new Cat("Oz", 3, "orange and white");
            secondCat.Name = "Ozzy";
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();

            Dog spot = new Dog("long", 12, true);
            Console.WriteLine(spot.HairLength);*/
            //spot.Potty();
            //spot.Run();

            //To create a new object, we use a special method called a CONSTRUCTOR  
            //Thinking about objects in real life, create 3 examples of objects.
            //Your objects should have five states (characteristics) and 5 behaviours.
            //house - living spaces, windows, doors, deck, driveway
            //- heats/cools, if mobile can move, protects family
            //wife- beautiful, smart, good looking, marginally tall, blue eyes
            //-witty, tells me what to do, loves
            //ping pong ball - round, lightweight, white, small, hollow
            //-moves, illusive, bounces

            Superhero firstHero = new Superhero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;
            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            Superhero secondHero = new Superhero("Diamond Daniel");
            Console.WriteLine(secondHero.StrengthLevel);

            secondHero.AllyGained();
            Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHero = new Superhero("The Best Ever", "Black Unitard",
                1000, "Being the best", false);
            thirdHero.BattleNemesis();
            Console.WriteLine("Oh, no! Now my costume is " + thirdHero.Costume);
            Console.WriteLine("And my strength has diminished to " + thirdHero.StrengthLevel);
            
        }
    }
}
