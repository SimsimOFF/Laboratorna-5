using System;

namespace Laboratorna_5_3
{
    class Program
        {
            static void Main(string[] args)
            {
                MyList<char> mylist = new MyList<char>();
                for (int i = 10; i < 20; i++)
                {
                    mylist.Add((char)i);
                }
                Console.WriteLine(new string('=', 10));
                Console.WriteLine(mylist.Count);
                Console.WriteLine(new string('=', 10));
                
                for (int i = 0; i < mylist.Count; i++)
                {
                    Console.WriteLine(mylist.GetArray()[i]);

                }
            }
        }
}