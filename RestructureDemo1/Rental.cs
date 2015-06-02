using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
   public class Rental
    {
       public Movie Movie { get; set; }
       public int DaysRented { get; set; }
      public double GetChange()
      {
          return Movie.GetChange(DaysRented);
      }
       public int GetFrequentRenterPoints()
       {
           return Movie.GetFrequentRenterPoints(DaysRented);
       }
    }
}
