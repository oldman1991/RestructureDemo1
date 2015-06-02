using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Customer customer=new Customer();
            customer.Name = "peng.li";
            List<Rental> listRentals=new List<Rental>();
            customer.ListRentals=listRentals;
          Console.WriteLine(customer.Statement());
            Console.ReadKey();
        }
    }
}
