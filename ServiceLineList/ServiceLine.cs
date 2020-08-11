using Mamaosem.Utils;
using MamaosemSystem.Stations;
using MamaosemSystemNew;
using MamaosemSystemNew.ServiceLineList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MamaosemSystem
{
    public class ServiceLine : IServiceLine
    {
        private LinkedList<IStationPreformer> _listStations;

        public int NumberWorks { get; set; }
        public ServiceLine(int numberWorks, LinkedList<IStationPreformer> listStations)
        {
            NumberWorks = numberWorks;
            _listStations = listStations;
        }


        public void CreateNewHouseCake() 
        {
            string AllCakeStr = GetAllCackesToString();
            Console.WriteLine("Hello please enter which house cake do you want from here");
            Console.WriteLine(AllCakeStr);


            int numberCakeChoise = InputValidation.ValidationInt();


            while (numberCakeChoise != -1)
            {
                    // validate the choise cake is current
                    bool isTypeCakeExists = Enum.IsDefined(typeof(CakeType), numberCakeChoise);
                    while (!isTypeCakeExists)
                    {
                        Console.WriteLine($"The cake {numberCakeChoise} is not exist in system");
                        Console.WriteLine(AllCakeStr);
                        numberCakeChoise = int.Parse(Console.ReadLine());
                        isTypeCakeExists = Enum.IsDefined(typeof(CakeType), numberCakeChoise);
                    }

                    CakeType CakeType = (CakeType)numberCakeChoise;


                    // exetue the create cake
                    int countStation = 0;
                    var station = _listStations.First;
                    while (station != null)
                    {
                        countStation++;
                        HouseCake houseCack = new HouseCake { Type = CakeType };
                        station.Value.PreformStep(countStation, houseCack);
                        station = station.Next;
                    }
                    Console.WriteLine("Hello please enter which house cake do you want from here");
                    Console.WriteLine(AllCakeStr);

                    numberCakeChoise = InputValidation.ValidationInt();

            }
            

        }

        public string GetAllCackesToString() 
        {
            string msg = "";
            foreach (var cake in Enum.GetValues(typeof(CakeType)))
            {
                msg += $"{(int)cake}  , name {cake} {Environment.NewLine}";
            }
            msg += $"Enter -1 to exist {Environment.NewLine}";
            return msg;
        }

    }
}
