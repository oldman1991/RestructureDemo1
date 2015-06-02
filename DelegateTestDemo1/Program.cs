using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestDemo1
{
    class Program
    {
        static double Double(double input)
        {
            return input*input;
        }
        static void Main(string[] args)
        {
//            MathAction ma = Double;
            MathAction ma = delegate(double input) { return input*input; };
            MathAction m2 = s => s*s;
           double res= ma(3.14);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private delegate double MathAction(double num);

    }
}
