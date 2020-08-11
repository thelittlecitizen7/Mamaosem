using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem.Stations
{
    public interface IStationPreformer
    {
        void PreformStep(int numberStation,HouseCake houseCake);
    }
}
