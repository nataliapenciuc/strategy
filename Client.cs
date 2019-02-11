using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
    public class Client
    {
        public static void Execute()
        {
            try
            {
                AnimalBasicVitalFunction birdFunction;
                birdFunction = new AnimalBasicVitalFunction(new Bird());
               
                var isPredator = birdFunction.IsPredator();
                Console.WriteLine("Is a predator: " + isPredator);
                Console.WriteLine("Reproducing function: " + birdFunction.GetReproducingWay());
                birdFunction.GetMovingBehavior();
                Console.WriteLine("Eating function" + birdFunction.GetEatingBehavior());

                AnimalBasicVitalFunction catFunction = new AnimalBasicVitalFunction(new Cat());
                Console.WriteLine("Is a predator: " + catFunction.IsPredator());
                Console.WriteLine("Reproducing function: " + catFunction.GetReproducingWay());
                catFunction.GetMovingBehavior();

                Console.WriteLine("Eating function" + catFunction.GetEatingBehavior());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}
