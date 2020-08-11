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
        int NumberStation { get; set; }
        void PreformStep(HouseCake houseCake);
    }
}
