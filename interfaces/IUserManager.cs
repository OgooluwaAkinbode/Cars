using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.models;

namespace CarSalesApp.interfaces
{
    public interface IUserManager
    {
        public User RegisterUser(string firstName, string lastName, string email, string password, string phoneNumber);
        public User Login(string email, string password);
        public User GetUser(int id);
        public User GetUser(string email);
        public void GetAllUser();
        public User UpdateUser(string firstName, string lastName, string phoneNumber);
        public User DeleteUser(string email);
    }
}