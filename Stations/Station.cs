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

        public int NumberStation { get; set; }
        public Station(int numberStation)
        {
            NumberStation = numberStation;
        }

        public void PreformStep(HouseCake houseCake) 
        {
            Console.WriteLine($"The station that working now is {NumberStation}");
            ProductionLineService.PerformProdLineStep(NumberStation,houseCake);
        }

        
    }
}
