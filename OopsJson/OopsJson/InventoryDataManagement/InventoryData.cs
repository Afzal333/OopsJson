using OopsJsonProblems.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopsJson.InventoryDataManagement
{
    public class InventoryData
    {
        public List<Inventory> Rice { get; set; }
        public List<Inventory> Wheat { get; set; }
        public List<Inventory> Pulse { get; set; }
    }
}
