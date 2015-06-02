using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
   public  class NewReleasePrice:Price
    {
       public override int GetPriceCode()
       {
           return Movie.NewRelease;
       }
       public override double GetChange(int daysRented)
       {
           return daysRented*3;
       }

       public override int GetFrequentRenterPoints(int daysRented)
       {
           return (daysRented > 1) ? 2 : 1;
       }
    }
}
