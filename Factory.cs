using Mamaosem.Utils;
using MamaosemSystem.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem
{
    public class Factory
    {
        private List<IStationPreformer> _listServiceLine;
        
        public Factory(List<IStationPreformer> listServiceLine)
        {
            _listServiceLine = listServiceLine;
        }


        
    }


    
}
