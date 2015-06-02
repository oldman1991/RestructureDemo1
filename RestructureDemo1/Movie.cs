using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RestructureDemo1
{
 public class Movie
 {
     public const int Children = 2;
     public const int Regular = 0;
     public const int NewRelease = 1;
     public string Title { get; set; }
     public int PriceCode { get; set; }
     private Price _price;
     public int GetPriceCode()
     {
         return _price.GetPriceCode();
     }
     public void SetPriceCode(int arg)
     {
         switch (arg)
         {
             case Regular:
                 _price=new RegularPrice();
                 break;
             case NewRelease:
                 _price = new NewReleasePrice();
                 break;
             case Children:
                 _price = new ChildrenPrice();
                 break;
             default:
                break;
    
         }
     }
     public double GetChange(int daysRented)
     {
         return _price.GetChange(daysRented);
     }

     public int GetFrequentRenterPoints(int daysRented)
     {
         return _price.GetFrequentRenterPoints(daysRented);
     }
 }
}
