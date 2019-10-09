using System;
using System.Collections.Generic;

namespace ThePound.Models
{
     abstract public class Dog
    {
        int Hunger {get;set;}
        int Sleepy {get;set;}
        int Happy {get;set;}
        int Age {get;set;}
        string Name {get;set;}

        public Dog(string name)
        {
            Name = name;
            Hunger = 20;
            Sleepy = 0;
            Happy=0;
            Age = 0;
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
    }
    public class GoldenRetriever : Dog
    {
        public GoldenRetriever(string name) : base(name) { }
    }
    public class BostonTerrier : Dog
    {
        public  BostonTerrier(string name) : base(name) { }
    }
    public class KingCharlesCavalier : Dog
    {
        public KingCharlesCavalier(string name) : base(name) { }
    }

    public class Home
    {
        int Day {get;set;}
        List<Dog> Dogs {get;set;}

        public Home()
        {
            Day = 0;
            Dogs = new List<Dog>();
        }
    }
}
