using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
   public  class RegularPrice:Price
    {
       public override int GetPriceCode()
       {
           return Movie.Regular;
       }
       public override double GetChange(int daysRented)
       {
           double result = 2;
           if (daysRented > 2)
           {
               result += (daysRented - 2) * 1.5;
           }
           return result;
       }
    }
}
