using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
   public class Snake : IBasicVitalFunctions
    {
        public string Eat()
        {
            return "I swallow mice and birds";
        }

        public bool IsPredator()
        {
            return true;
        }

        public void Moving()
        {
           Console.WriteLine("I crawl through bushes");
        }

        public string ReproducingWay()
        {
            return "I make eggs";
        }
    }
}
