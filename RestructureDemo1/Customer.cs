using System.Collections.Generic;
using System.Linq;

namespace RestructureDemo1
{
    public class Customer
    {
        public List<Rental> ListRentals = new List<Rental>();
        public string Name { get; set; }

        public string Statement()
        {
            string result = "Rental Record for " + Name + "\n";
            result = ListRentals.Aggregate(result, (current, item) => current + ("\t" + item.Movie.Title + "\t" + item.GetChange() + "\n"));
            result += "Amount owed is " + GetTotalCharg() + "\n";
            result += "You earned " + GetTotalfrequentRenterPoints() + " frequent renter points";
            return result;
        }

        private double GetTotalCharg()
        {
            return ListRentals.Sum(listRental => listRental
.GetChange());
        }
        private double GetTotalfrequentRenterPoints()
        {
            return ListRentals.Aggregate<Rental, double>(0, (current, listRental) => current + listRental.GetFrequentRenterPoints());
        }
    }
}