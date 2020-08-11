using Mamaosem.Utils;
using MamaosemSystem.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem
{
    public class Station : IStationPreformer
    {
        public Station()
        {
         
        }

        public void PreformStep(int numberStation,HouseCake houseCake) 
        {
            Console.WriteLine($"The station {numberStation} working on ${houseCake}");
            ProductionLineService.PerformProdLineStep(numberStation,houseCake);

            
        }

        
    }
}
