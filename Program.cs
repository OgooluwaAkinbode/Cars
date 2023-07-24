using System;
using CarSalesApp.implementations;
using CarSalesApp.menu;

namespace CarSalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //  UserManager userManager= new UserManager();
            // userManager.ReadFromUser();
            // CustomerManager customerManager= new CustomerManager();
            // // customerManager.ReadFromCustomer();
            // ManagerManager managerManager= new ManagerManager();
            // managerManager.ReadFromManager();
            // SuperAdminManager superAdminManager= new SuperAdminManager();
            // superAdminManager.ReadFromSuperAdmin();
            // CarManager carManager= new CarManager();
            // carManager.ReadCarFromFile();
            MainMenu mainMenu = new MainMenu();
            mainMenu.RealMenu();
        }
    }
}
