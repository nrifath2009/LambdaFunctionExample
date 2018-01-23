using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionExample
{
    class Program
    {
        public delegate int MyDelegate(int x);
        public delegate void MyDelegate2(int x, string prefix);
        public delegate bool ExprDelegate(int x);
        static void Main(string[] args)
        {
            MyDelegate foo = (x) => x * x;
            Console.WriteLine("The result of foo is {0}",foo(5));
            foo = (x) => x * 10;
            Console.WriteLine("The result of bar is {0}", foo(5));


            MyDelegate2 bar = (x, y) =>
            {
                Console.WriteLine("The two arg lambda: {1} {0}", x * 10, y);
            };
            bar(25, "some string");

            ExprDelegate baz = (x) => x > 10;
            Console.WriteLine("Calling baz with 5 {0}", baz(5));
            Console.WriteLine("Calling baz with 15 {0}", baz(15));


            Console.ReadKey();
        }
    }
}
