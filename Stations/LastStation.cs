using Mamaosem.Utils;
using MamaosemSystem.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem
{
    public class LastStation : IStationPreformer
    {
        public int NumberWorks { get; set; }

        public int NumberStation { get; set; }

        public LastStation(int numberStation, int numberWorks)
        {
            NumberWorks = numberWorks;
            NumberStation = numberStation;
        }

        public void PreformStep(HouseCake houseCake)
        {
            // save in .storage file
        }
    }
}
