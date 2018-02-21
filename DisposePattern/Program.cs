using System;

namespace DisposePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (myClass classe = new myClass("c://"))
            {

            }
            Console.ReadLine();
        }
    }
}
