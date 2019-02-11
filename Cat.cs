using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
   public class Cat : IBasicVitalFunctions
    {
        public string Eat()
        {
          return  "I like to be fed but also I like to hunt";
        }

        public bool IsPredator()
        {
            return true;
        }

        public void Moving()
        {
            Console.WriteLine("I can jump but also walk");
        }

        public string ReproducingWay()
        {
            return "I give birth to kittens and I feed them with milk ";
        }
    }
}
