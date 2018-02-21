using System;

namespace DisposePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyClass classe = new MyClass("c://"))
            {

            }
            Console.ReadLine();
        }
    }
}
