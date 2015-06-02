using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
   public class ChildrenPrice:Price
    {
       public override int GetPriceCode()
       {
           return Movie.Children;
       }
       public override double GetChange(int daysRented)
         {
             double result = 1.5;
             if (daysRented>3)
             {
                 result += (daysRented - 3)*1.5;
             }
             return result;
         }
    }
}
