using Mamaosem.Utils;
using MamaosemSystem.Stations;
using MamaosemSystemNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaosemSystem
{
    public class LastStation : IStationPreformer
    {
        private StorageCakes _storageCakes { get; set; }
        public LastStation()
        {
            _storageCakes = new StorageCakes();
        }

        public void PreformStep(int numberStation ,HouseCake houseCake)
        {
            Console.WriteLine($"The station that working now is {numberStation}");
            ProductionLineService.PerformProdLineStep(numberStation, houseCake);
            // save in .storage file

            DateTime creationDate = DateTime.Now;
            DateTime expireDate = DateTime.Now.AddDays(10);

            houseCake.ExpiryDate = expireDate;
            houseCake.ProductionTime = creationDate;

            string cakeMsg = $"{houseCake.ToString()} , name : {houseCake.Type}, createionTime {creationDate} , expiryDate {expireDate}";
            _storageCakes.AddCake(cakeMsg);
            Console.WriteLine("Save product");
        }
    }
}
