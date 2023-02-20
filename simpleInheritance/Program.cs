using System;
using System.Data.Common;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name} \n");
        }

    }
    class Wolf : Animal
    {
        public string sound;
        public string food;
        public double height;
        public Wolf()
        // calls the Animal class constructor
        {
            sound = "";
            food = "";
            height = 0;
        }
        public void displayAll()
        {
            Console.WriteLine("Wolf information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Sound: {sound}");
            Console.WriteLine($"Food: {food}");
            Console.WriteLine($"Height: {height}\n");

        }
        public Wolf(string name, string sound, string food, double height)
           : base(name)
        {
            this.sound = sound;
            this.food = food;
            this.height = height;
        }

    }

    class Giraffe : Animal
    {
        public string sound;
        public string food;
        public double height;
        public Giraffe()
         // calls the Animal class constructor
        {
            sound = "";
            food = "";
            height = 0;
        }
        public void displayAll()
        {
            Console.WriteLine("Giraffe information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Sound: {sound}");
            Console.WriteLine($"Food: {food}");
            Console.WriteLine($"Height: {height} \n");
        }
        public Giraffe(string name, string sound, string food, double height)
            : base(name)
        {
            this.sound = sound;
            this.food = food;
            this.height = height;
        }

    }

    // derived class of Animal 
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Wolf wolf= new Wolf();

            wolf.name = "Floofer";
            wolf.sound = "OW-OW-AWOOOOOO";
            wolf.food = "Large Animals";
            wolf.height = 3.2;
            wolf.displayAll();
            //derived class object using parameterized constructor
            Wolf jelly = new Wolf("Jellybean", "AWWWWWWOO", "Big meaty animals", 3.4);
            jelly.displayAll();

            Giraffe steven = new Giraffe();
            steven.name = "Steven";
            steven.sound = "MNAaa";
            steven.food = "Leaves";
            steven.height= 15.5;
            steven.displayAll();

            Giraffe stone = new Giraffe("Stone","MNAM Mnam", "Lettuce n' such",17.4);
            stone.displayAll();
        }

    }
}

