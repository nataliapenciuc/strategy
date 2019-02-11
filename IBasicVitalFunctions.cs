using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.strategy
{
   public interface IBasicVitalFunctions
   {
       string Eat();
       void Moving();
       bool IsPredator();
       string ReproducingWay();

   }
}
