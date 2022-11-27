using System;
using OopsJson.InventoryDataManagement;
using OopsJsonProblems.InventoryManagement;

namespace OopsJsonProblems
{
    internal class Program
    {
        static string inventoryFile = @"D:\Bridgelabs\OopsJson\OopsJson\OopsJson\InventoryManagement\Inventory.json";
        static string inventoryFileData = @"D:\Bridgelabs\OopsJson\OopsJson\OopsJson\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option \n 1.Inventory Management \n"+ " 2.Inventory Data managment(IDM) - Read and Display \n 3.IDM - ADD \n 4.IDM - Edit \n 5.IDM-Delte \n 6.IDM - ALL DELETE");
                int option = Convert.ToInt32(Console.ReadLine());
                InventoryManage InventoryManage = new InventoryManage();
                InventoryDataMgnt inventoryDataMgnt = new InventoryDataMgnt();

                switch (option)
                {
                    case 1:
                        InventoryManage.ReadJSonFile(inventoryFile);
                        break;
                    case 2:
                        inventoryDataMgnt.Dislay(inventoryFileData);
                        break;
                    case 3:
                        inventoryDataMgnt.ReadJsonFile(inventoryFileData);
                        Console.Write("Enter Inventory Name to add(Rice, Wheat, Pulse) : ");
                        string addName = Console.ReadLine();
                        inventoryDataMgnt.AddInventoryData(addName);
                        inventoryDataMgnt.WriteJsonFile(inventoryFileData);
                        break;
                    case 4:
                        inventoryDataMgnt.ReadJsonFile(inventoryFileData);
                        Console.Write("Enter Inventory Name to edit(Rice, Wheat, Pulse) : ");
                        string editName = Console.ReadLine();
                        inventoryDataMgnt.EditInventoryData(editName);
                        inventoryDataMgnt.WriteJsonFile(inventoryFileData);
                        break;
                    case 5:
                        inventoryDataMgnt.ReadJsonFile(inventoryFileData);
                        Console.Write("Enter Inventory Name to delte(Rice, Wheat, Pulse) : ");
                        string deleteName = Console.ReadLine();
                        inventoryDataMgnt.DeleteInventoryData(deleteName);
                        inventoryDataMgnt.WriteJsonFile(inventoryFileData);
                        break;
                    case 6:
                        inventoryDataMgnt.ReadJsonFile(inventoryFileData);
                        Console.Write("Enter Inventory Name to all delte(Rice, Wheat, Pulse) : ");
                        string deleteAll = Console.ReadLine();
                        inventoryDataMgnt.AllDelteInventoryData(deleteAll);
                        inventoryDataMgnt.WriteJsonFile(inventoryFileData);
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
