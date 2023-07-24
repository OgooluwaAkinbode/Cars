using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.implementations;
using CarSalesApp.interfaces;

namespace CarSalesApp.menu
{
    public class CustomerMenu
    {
        ICustomerManager customerManager = new CustomerManager();
        IUserManager userManager = new UserManager();
        ICarManager carManager = new CarManager();
        public void RealCustomerMenu()
        {
            Console.WriteLine("Enter 1 to view all cars\nenter 2 to fund wallet\nenter 3 to withdraw\nenter 4 to view wallet balance\nenter 5 to buy cars\nenter 0 to logout");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                carManager.GetAllCars();
                RealCustomerMenu();
            }
            else if (option == 2)
            {
                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                Console.Write("Enter the password:");
                string password = Console.ReadLine();
                Console.Write("Enter the amount:");
                decimal amount = decimal.Parse(Console.ReadLine());
                customerManager.FundWalet(email, password, amount);

                RealCustomerMenu();
            }
            else if (option == 3)
            {

                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                Console.Write("Enter the password:");
                string password = Console.ReadLine();
                Console.Write("Enter the amount:");
                decimal amount = decimal.Parse(Console.ReadLine());
                customerManager.Withdraw(email, password, amount);

                RealCustomerMenu();
            }
            else if (option == 4)
            {
                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                Console.Write("Enter the password:");
                string password = Console.ReadLine();
                customerManager.WalletBalance(email, password);

                RealCustomerMenu();
            }
            else if (option == 5)
            {
                carManager.GetAllCars();
                Console.WriteLine("Enter your id");
                int id = int.Parse(Console.ReadLine());
                if (id <= 0 || id > CarManager.carsDatabase.Count)
                {
                    Console.WriteLine("car does not exist");
                    RealCustomerMenu();
                }
                else
                {
                    carManager.BuyCar(id);
                   
                    RealCustomerMenu();
                }
                RealCustomerMenu();
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
                RealCustomerMenu();
            }
        }

    }
}