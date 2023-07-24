using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.interfaces;
using CarSalesApp.models;

namespace CarSalesApp.implementations
{
    public class CustomerManager : ICustomerManager
    {

        IUserManager userManager = new UserManager();

         public static List<Customer> CustomerDatabase = new List<Customer>{
            new Customer();
         };
       

       
        public bool DeleteCustomer(int userId)
        {
            bool flag = false;
            foreach (var customer in CustomerDatabase)
            {
                if (customer.UserId == userId)
                {
                    var user = userManager.GetUser(userId);
                    CustomerDatabase.Remove(customer);
                    flag = true;
                }

            }
            return flag;
        }

        public void GetAllCustomers()
        {
            foreach (var customer in CustomerDatabase)
            {
                var user = userManager.GetUser(customer.UserId);
                Console.WriteLine($"{user.Id}\t{user.FirstName}\t{user.LastName}\t{user.Email}\t{user.PhoneNumber}");
            }
        }

        public Customer GetCustomer(int userId)
        {
            foreach (var customer in CustomerDatabase)
            {
                if (customer.UserId == userId)
                {
                    return customer;
                }
            }
            return null;
        }


        public void RegisterCustomer()
        {
            var customer = new Customer(CustomerDatabase.Count + 1,false, UserManager.UserDatabase.Count, "Customer",0);
            CustomerDatabase.Add(customer);
            var user = userManager.GetUser(customer.UserId);

            Console.WriteLine($"Congrats mr/mrs {user.FirstName} {user.LastName}, you have registered successfully and has a bonus your wallet has been funded with 20000");
        }

        public Customer UpdateCustomer(string email)
        {
            foreach (var customer in CustomerDatabase)
            {
                var user = userManager.GetUser(email);
                if (user.Email == email)
                {
                    return customer;
                }
            }
            return null;
        }




        public Customer Get(string email)
        {
            var user = userManager.GetUser(email);
            foreach (var customer in CustomerDatabase)
            {
                if (user.Id == customer.UserId)
                {
                    return customer;
                }
            }
            return null;

        }

       

        public void WalletBalance(string email, string password)
        {
            foreach(var customer in CustomerDatabase)
            {
                var user= userManager.GetUser(email);
                if(user.Email == email && user.Password == password)
                {
                    Console.WriteLine($"Your wallet balance is {customer.Wallet}");
                }
            }
        }

        public void FundWalet(string email, string password, decimal amount)
        {
             var user = userManager.GetUser(email);
            if (user != null && user.Password == password)
            {
                var customer = GetCustomer(user.Id);
                customer.Wallet += amount;
                Console.WriteLine($"Wallet has been successfully updated and new balance is {customer.Wallet}");
            }
            else
            {
                Console.WriteLine($"Wallet does not exist!");
            }
        }

        public void Withdraw(string email, string password, decimal amount)
        {
             var user = userManager.GetUser(email);
            if (user != null && user.Password == password)
            {
                var customer = GetCustomer(user.Id);
                if (customer.Wallet > amount)
                {
                    customer.Wallet -= amount;
                    Console.WriteLine($"{amount} has been deducted from wallet and total balance is now {customer.Wallet}");
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
            else
            {
                Console.WriteLine($"Wallet does not exist!");
            }
        }


    }
}