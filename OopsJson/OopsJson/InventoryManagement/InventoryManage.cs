using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OopsJsonProblems.InventoryManagement
{
    public class InventoryManage
    {
        public void ReadJSonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(JsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "  " + data.Weight + "  " + data.Price);
            }
        }
    }
}
