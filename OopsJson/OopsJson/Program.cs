using System;
using OopsJsonProblems.InventoryManagement;

namespace OopsJsonProblems
{
    internal class Program
    {
        static string inventoryFile = @"D:\Bridgelabs\OopsJson\OopsJson\OopsJson\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option \n 1.Inventory Management");
                int option = Convert.ToInt32(Console.ReadLine());
                InventoryManage InventoryManage = new InventoryManage();

                switch (option)
                {
                    case 1:
                        InventoryManage.ReadJSonFile(inventoryFile);
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
