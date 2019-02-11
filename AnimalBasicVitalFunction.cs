using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
   public class AnimalBasicVitalFunction
   {
       public IBasicVitalFunctions Animal { get; set; }

        public AnimalBasicVitalFunction()
        {

        }

        public AnimalBasicVitalFunction(IBasicVitalFunctions functions)
        {
            Animal = functions;
        }

   
        public string GetEatingBehavior()
        {

            return Animal.Eat();
        }
        public void GetMovingBehavior()
        {
            this.Animal.Moving();

        }

        public bool IsPredator()
        {
            return Animal.IsPredator();
        }

        public string GetReproducingWay()
        {
            return Animal.ReproducingWay();
        }


    }
}
