using Mamaosem.Utils;
using MamaosemSystem;
using MamaosemSystem.Stations;
using MamaosemSystemNew.ServiceLineList;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MamaosemSystemNew
{
    class Program
    {
        static void Main(string[] args)
        {


              LinkedList<IStationPreformer> stationPreformersList = new LinkedList<IStationPreformer>();


              stationPreformersList.AddLast(new Station());
              stationPreformersList.AddLast(new Station());
              stationPreformersList.AddLast(new Station());
              stationPreformersList.AddLast(new LastStation());

              List<IServiceLine> serviceLinesList = new List<IServiceLine>();
              serviceLinesList.Add(new ServiceLine(1, stationPreformersList));

              Factory Factory = new Factory(serviceLinesList);
              Factory.Run();

            
        }

           
       
    }
}
