using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
    public class Bird : IBasicVitalFunctions
    {
        public string Eat()
        {
            return "I like to pick grains or insects";
        }

        public bool IsPredator()
        {
            return true;
        }

        public void Moving()
        {
            Console.WriteLine("I can fly but also dance");
        }

        public string ReproducingWay()
        {
            return "I lay eggs";
        }
    }
}
