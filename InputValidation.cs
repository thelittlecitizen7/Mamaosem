using System;
using System.Collections.Generic;
using System.Text;

namespace MamaosemSystemNew
{
    public static class InputValidation
    {
        public static int ValidationInt() {
            int number = 0;
            bool isRunning = true;
            while (isRunning) {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    isRunning = false;
                }
                catch (Exception e) {
                    Console.WriteLine("The input must be number");
                }
            }
            
            return number;
        }
    }
}
