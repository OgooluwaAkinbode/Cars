using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.implementations;
using CarSalesApp.interfaces;

namespace CarSalesApp.menu
{
    public class CarMenu
    {
        CarManager carManager = new CarManager();
        IUserManager userManager = new UserManager();

        public void RealCarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 1 to add cars");
            Console.WriteLine("Enter 2 to view all cars");
            Console.WriteLine("Enter 0 to go back");
            int option= int.Parse(Console.ReadLine());
            if(option == 1)
            {
                // Console.WriteLine("Enter the id");
                // int id= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the carname");
                string name= Console.ReadLine();
                Console.WriteLine("Enter the carmodel");
                int model= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the price");
                decimal price= decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity= int.Parse(Console.ReadLine());
                carManager.AddCars(name,model,price,quantity);
                RealCarMenu();
            }
            else if(option == 2)
            {
                carManager.GetAllCars();
                RealCarMenu();
            }
            else if(option == 0)
            {
                MainMenu mainMenu= new MainMenu();
                mainMenu.RealMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
           
           
           

        }
        
    }
}