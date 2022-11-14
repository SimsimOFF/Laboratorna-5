using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorna_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = MyFactory<MyClass>.FacrotyMethod();

            Console.ReadKey();

        }
    }
}