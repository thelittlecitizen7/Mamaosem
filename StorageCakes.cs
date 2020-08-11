using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MamaosemSystemNew
{
    public class StorageCakes
    {

        public string path { get; set; }



        public StorageCakes()
        {
            path = @"C:\Users\thelittlecitizen7\source\repos\MamaosemSystemNew\MamaosemSystemNew\StorageCackes.storage";
        }

        public void AddCake(string cakesData)
        {
            string[] lines = File.ReadAllLines(path);

            List<string> allLinesLists = lines.ToList<string>();
            allLinesLists.Add(cakesData);

            File.WriteAllText(path,string.Empty);

            string msg = "";
            foreach (var line in allLinesLists)
            {
                msg += $"{line} {Environment.NewLine}";

            }
            File.WriteAllText(path, msg);

        }
    }
}
