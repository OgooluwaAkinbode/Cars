using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.implementations;
using CarSalesApp.interfaces;

namespace CarSalesApp.menu
{
    public class ManagerMenu
    {
        IUserManager userManager = new UserManager();
        CarMenu carMenu = new CarMenu();
        ICustomerManager customerManager = new CustomerManager();
        public void RealManagerMenu()
        {
            Console.WriteLine("Enter 1 to go to carMenu\nenter 2 to view all customers\nenter 0 to go back");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                carMenu.RealCarMenu();
            }
            else if (option == 2)
            {
                customerManager.GetAllCustomers();
                RealManagerMenu();
            }

            else if (option == 0)
            {
                MainMenu mainMenu = new MainMenu();
                Console.WriteLine("user has successfully logout");
                mainMenu.RealMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
                RealManagerMenu();
            }
        }
    }
}