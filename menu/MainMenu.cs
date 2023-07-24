using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.implementations;
using CarSalesApp.interfaces;

namespace CarSalesApp.menu
{
    public class MainMenu
    {
        // IList<UserManager> customers = new List<UserManager>();
        IUserManager userManager = new UserManager();
        ICustomerManager customerManager = new CustomerManager();
        ISuperAdminManager superAdminManager = new SuperAdminManager();
        IManagerManager managerManager = new ManagerManager();
        CustomerMenu customerMenu = new CustomerMenu();
        SuperAdminMenu superAdminMenu = new SuperAdminMenu();
        ManagerMenu managerMenu = new ManagerMenu();
        public void RealMenu()
        {
            Console.WriteLine($"Welcome to Jumia Car Sales Management App");
            Console.WriteLine($"Enter 1 to signup:");
            Console.WriteLine($"Enter 2 to login:");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SignUpMenu();
                    break;
                case 2:
                    LoginMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public void SignUpMenu()
        {
            Console.WriteLine($"***SIGNUP***");
            Console.Write("Enter your firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your lastname:");
            string lastname = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            userManager.RegisterUser(firstname, lastname, password, email, phoneNumber);
            customerManager.RegisterCustomer();
            
            RealMenu();
        }

        public void LoginMenu()
        {
            Console.Write(" ");
            Console.WriteLine("***LOG IN***");
            Console.Write("Enter your email:");
            string email = Console.ReadLine();
            Console.Write("Enter your password:");
            string password = Console.ReadLine();
            var userLogin = userManager.Login(email, password);


            if (userLogin is not null)
            {
                // Console.WriteLine("Check");
                Console.WriteLine("Login successful");

                var superAdmin = superAdminManager.Get(userLogin.Email);
                var customer = customerManager.Get(userLogin.Email);
                var manager = managerManager.Get(userLogin.Email);
                if (superAdmin != null)
                {
                    superAdminMenu.RealSuperAdminMenu();
                }
                else if (customer != null)
                {
                    customerMenu.RealCustomerMenu();
                }
                else if (manager != null)
                {
                    managerMenu.RealManagerMenu();
                }

            }
            else
            {
                Console.WriteLine("invalid email or password");
                RealMenu();
            }
            


        }
    }
}