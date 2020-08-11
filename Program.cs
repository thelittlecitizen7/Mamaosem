using Mamaosem.Utils;
using System;

namespace MamaosemSystemNew
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string name in Enum.GetNames(typeof(CakeType)))
            {
                System.Console.WriteLine(name);
            }


            foreach (var name in Enum.GetValues(typeof(CakeType)))
            {
                System.Console.WriteLine((int)name);
            }
        }
    }
}
