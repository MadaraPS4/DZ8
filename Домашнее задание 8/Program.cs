using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m[0] = 5;
            Console.WriteLine(m[0]);

            Console.ReadKey();

        }
    }
}
