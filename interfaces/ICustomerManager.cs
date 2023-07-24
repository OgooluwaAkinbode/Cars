using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.models;

namespace CarSalesApp.interfaces
{
    public interface ICustomerManager
    {
        public void RegisterCustomer();
        public Customer GetCustomer(int userId);
        public Customer UpdateCustomer(string email);
        public bool DeleteCustomer(int userId);
        public Customer Get(string email);
        public void GetAllCustomers();
        public void FundWalet(string email, string password, decimal amount);
        public void Withdraw(string email, string password, decimal amount);
        public void WalletBalance(string email, string password);

    }
}