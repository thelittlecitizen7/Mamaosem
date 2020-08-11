using Mamaosem.Utils;
using MamaosemSystem.Stations;
using MamaosemSystemNew;
using MamaosemSystemNew.ServiceLineList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace MamaosemSystem
{
    public class Factory
    {
        private List<IServiceLine> _listServiceLine;

        public Factory(List<IServiceLine> listServiceLine)
        {
            _listServiceLine = listServiceLine;
        }

        public void Run()
        {
            Console.WriteLine("Please enter which Service Line you want to activate");
            string allLineStr = GetAllLines();
            Console.WriteLine(allLineStr);

            int lineChoise = InputValidation.ValidationInt();
            IServiceLine serviceLine = _listServiceLine.ElementAtOrDefault(lineChoise);


            while (serviceLine == null)
            {
                Console.WriteLine($"The line {lineChoise} is not exist in system");
                Console.WriteLine(allLineStr);
                lineChoise = InputValidation.ValidationInt();
                serviceLine = _listServiceLine.ElementAtOrDefault(lineChoise);
            }
            serviceLine.CreateNewHouseCake();
        }

        public string GetAllLines()
        {
            int countLine = 0;
            string msg = "";
            foreach (var line in _listServiceLine)
            {
                msg += $"number line : {countLine} {Environment.NewLine}";
            }

            return msg;
        }

    }
    
}
