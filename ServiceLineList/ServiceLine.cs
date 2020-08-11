using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem
{
    public class ServiceLine
    {
        private LinkedList<Station> _listStations;

        public int NumberWorks { get; set; }
        public ServiceLine(int numberWorks, LinkedList<Station> listStations)
        {
            NumberWorks = numberWorks;
            _listStations = listStations;
        }


        public void CreateNewHouseCake() 
        {
            Console.WriteLine("Hello please enter which house cake do you want");
            Console.WriteLine(GetAllCackesToString());
            int numberCake = int.Parse(Console.ReadLine());
            CakeType CakeType = GetCackByNumber(numberCake);

            LinkedListNode<Station> station = _listStations.First;
            while (station != null) 
            {
                HouseCake houseCack = new HouseCake { Type = CakeType };
                station = station.Next;
                station.Value.PreformStep(houseCack);
            }
            
        }

        public string GetAllCackesToString() 
        {
            string msg = "";
            foreach (string name in Enum.GetNames(typeof(CakeType)))
            {
                msg += $"value :  0  , name {name} {Environment.NewLine}";
            }
            return msg;
        }


        // factory
        public CakeType GetCackByNumber(int numberCake) 
        {
            return CakeType.Checkers;
        }

        
    }
}
