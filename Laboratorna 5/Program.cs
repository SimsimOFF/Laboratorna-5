using System;
using System.Collections;

namespace Laboratorna_5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            Console.WriteLine("List capacity: {0} elements", mylist.Capacity);
            Console.WriteLine("The list actually contains: {0} elements", mylist.Count);
            mylist.Add(15);
            Console.WriteLine("List capacity: {0} elements", mylist.Capacity);

            Console.ReadKey();
        }
    }
}