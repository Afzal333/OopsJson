using Newtonsoft.Json;
using OopsJsonProblems.InventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsJson.InventoryDataManagement
{
    public class InventoryDataMgnt
    {
        InventoryData inventoryData;
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulseList;

        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            inventoryData = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            RiceList = inventoryData.Rice;
            WheatList = inventoryData.Wheat;
            PulseList = inventoryData.Pulse;
        }

        public void Dislay(string file)
        {
            ReadJsonFile(file);
            Read(RiceList);
            Read(WheatList);
            Read(PulseList);
        }

        public void Read(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.Price);
            }
            Console.WriteLine();
        }

        public void AddInventoryData(string inventoryName)
        {
            Inventory inventory = new Inventory();
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Price : ");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    RiceList.Add(inventory);
                    break;
                case "Wheat":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Price : ");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    WheatList.Add(inventory);
                    break;
                case "Pulse":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Price : ");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    PulseList.Add(inventory);
                    break;
            }
        }

        public void EditInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("enter name : ");
                    string nameRice = Console.ReadLine();
                    foreach (var rice in RiceList)
                    {
                        if (rice.Name.Equals(nameRice))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            rice.Name = editName;
                            rice.Weight = editWeight;
                            rice.Price = editPrice;
                        }
                    }
                    break;
                case "Wheat":
                    Console.Write("enter name : ");
                    string nameWheat = Console.ReadLine();
                    foreach (var wheat in WheatList)
                    {
                        if (wheat.Name.Equals(nameWheat))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            wheat.Name = editName;
                            wheat.Weight = editWeight;
                            wheat.Price = editPrice;
                        }
                    }
                    break;
                case "Pulse":
                    Console.Write("enter name : ");
                    string namePulse = Console.ReadLine();
                    foreach (var pulse in PulseList)
                    {
                        if (pulse.Name.Equals(namePulse))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            pulse.Name = editName;
                            pulse.Weight = editWeight;
                            pulse.Price = editPrice;
                        }
                    }
                    break;
            }
        }

        public void DeleteInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("Enter name to delete : ");
                    string deleteRice = Console.ReadLine();
                    try
                    {
                        foreach (var rice in RiceList)
                        {
                            if (rice.Name.Equals(deleteRice))
                            {
                                RiceList.Remove(rice);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Wheat":
                    Console.Write("Enter name to delete : ");
                    string deleteWheat = Console.ReadLine();
                    try
                    {
                        foreach (var wheat in WheatList)
                        {
                            if (wheat.Name.Equals(deleteWheat))
                            {
                                WheatList.Remove(wheat);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Pulse":
                    Console.Write("Enter name to delete : ");
                    string deletePulse = Console.ReadLine();
                    try
                    {
                        foreach (var pulse in PulseList)
                        {
                            if (pulse.Name.Equals(deletePulse))
                            {
                                PulseList.Remove(pulse);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }

        public void AllDelteInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    RiceList.Clear();
                    break;
                case "Wheat":
                    WheatList.Clear();
                    break;
                case "Pulse":
                    PulseList.Clear();
                    break;
            }
        }

        public void WriteJsonFile(string file)
        {
            var json = JsonConvert.SerializeObject(inventoryData);
            File.WriteAllText(file, json);
        }
    }
}
