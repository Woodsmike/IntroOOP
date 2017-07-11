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
            Random rName = new Random();
            Cat mittens = new Cat();
            mittens.Name = "Mittens";
            //To create a new object, we use a special method called a CONSTRUCTOR  
            //Thinking about objects in real life, create 3 examples of objects.
            //Your objects should have five states (characteristics) and 5 behaviours.
            //house - living spaces, windows, doors, deck, driveway
                    //- heats/cools, if mobile can move, protects family
            //wife- beautiful, smart, good looking, marginally tall, blue eyes
                    //-witty, tells me what to do, loves
            //ping pong ball - round, lightweight, white, small, hollow
                    //-moves, illusive, bounces
        }
    }
}
