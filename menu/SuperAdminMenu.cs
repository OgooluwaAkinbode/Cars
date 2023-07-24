using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.implementations;
using CarSalesApp.interfaces;

namespace CarSalesApp.menu
{
    public class SuperAdminMenu
    {
        IManagerManager managerManager = new ManagerManager();
        IUserManager userManager = new UserManager();

        public void RealSuperAdminMenu()
        {

            Console.WriteLine("enter 1 to view all Managers\nenter 2 to register Manager\nenter 0 to logout");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                managerManager.GetAllManager();
                RealSuperAdminMenu();
            }
            else if (option == 2)
            {
                Console.WriteLine($"***Register Manager***");
                Console.Write("Enter your firstname: ");
                string firstname = Console.ReadLine();
                Console.Write("Enter your lastname: ");
                string lastname = Console.ReadLine();
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                Console.Write("Enter your phone number: ");
                string phoneNumber = Console.ReadLine();

                userManager.RegisterUser(firstname, lastname, email, password, phoneNumber);
                managerManager.RegisterManager();
                RealSuperAdminMenu();

            }
            else if (option == 0)
            {
                MainMenu mainMenu = new MainMenu();
                Console.WriteLine("user has successfully logout");
                mainMenu.RealMenu();
            }
            else
            {
                Console.WriteLine("wrong input");
                RealSuperAdminMenu();
            }
        }
    }
}