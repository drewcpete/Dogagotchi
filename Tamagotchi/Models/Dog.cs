using System;
using System.Collections.Generic;

namespace ThePound.Models
{
      public class Dog
    {
        public int Hunger {get;set;}
        public int Happy {get;set;}
        public int Age {get;set;}
        public string Name {get;set;}
        public int Sleepy {get;set;}

        public Dog(string name)
        {
            Name = name;
            Hunger = 20;
            Sleepy = 0;
            Happy=0;
            Age = 0;
        }
        public Dog(string name, int age):this(name)
        {
            Age = age;
        }

        public string ReturnType()
        {
            if(this.GetType().ToString() == "ThePound.Models.GoldenRetriever")
            {
                return "Golden Retriever";
            }
            else if(this.GetType().ToString() == "ThePound.Models.BostonTerrier")
            {
                return "Boston Terrier";
            }
            else if (this.GetType().ToString() == "ThePound.Models.GermanShepard")
            {
                return "German Shepard";
            }
            else if (this.GetType().ToString() == "ThePound.Models.KingCharlesCavalier")
            {
                return "King Charles Cavalier";
            }
            else
            {
                return "Dog";
            }
        }

        public void LivingDepreciation()
        {
            Hunger++;
            Sleepy++;
            Happy--;
            Age++;
        }
        public string PlayFetch()
        {
            Hunger--;
            Sleepy++;
            Happy+=5;
            return Name + " is sleepier, hungrier, and super happy!";

        }
    }

    public class GermanShepard:Dog
    {
        public GermanShepard(string name):base(name){}
        public GermanShepard(string name, int age) : base(name,age){}
        public string ReturnType() 
        {
            return "German Shepard";
        }
    }
    public class GoldenRetriever : Dog
    {
        public GoldenRetriever(string name) : base(name) { }
        public GoldenRetriever(string name, int age) : base(name, age) { }
        public string ReturnType()
        {
            return "Golden Retriever";
        }
    }
    public class BostonTerrier : Dog
    {
        public  BostonTerrier(string name) : base(name) { }
        public BostonTerrier(string name, int age) : base(name, age) { }
        public string ReturnType()
        {
            return "Boston Terrier";
        }
    }
    public class KingCharlesCavalier : Dog
    {
        public KingCharlesCavalier(string name) : base(name) { }
        public KingCharlesCavalier(string name, int age) : base(name, age) { }
        public string ReturnType()
        {
            return "King Charles Cavalier";
        }
    }

    public class Home
    {
        public int Day { get;set; }
        public List<Dog> Dogs { get;set; }

        public static Home home = new Home();

        public Home()
        {
            Day = 0;
            Dogs = new List<Dog>();
        }

        public void AdoptDog(Dog dog)
        {
            Dogs.Add(dog);
        }
    }
}
