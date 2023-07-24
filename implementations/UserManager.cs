using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.interfaces;
using CarSalesApp.models;

namespace CarSalesApp.implementations
{
    public class UserManager : IUserManager
    {
        public static List<User> UserDatabase = new List<User>{
            new User(1,false)
        };

        public void GetAllUser()
        {
            foreach (var user in UserDatabase)
            {
               if(user.IsDeleted == false)
               {
                 Console.WriteLine($"{user.FirstName}/t{user.LastName}/t{user.Email}/t{user.PhoneNumber}");
               }
            }

        }

        public User GetUser(int id)
        {
             foreach (var user in UserDatabase)
            {
                if(user.Id == id && user.IsDeleted == false)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetUser(string email)
        {
            foreach (var user in UserDatabase)
            {
                if (user.Email == email && user.IsDeleted == false)
                {
                    return user;
                }
            }
            return null;
        }
       

        public User Login(string email, string password)
        {
            foreach (var user in UserDatabase)
            {
                if(user.Email == email && user.Password == password && user.IsDeleted == false)
                {
                
                    return user;
                }
            }
            return null;
        }

        public User RegisterUser(string firstName, string lastName,string password, string email, string phoneNumber)
        {
            var userExists = GetUser(email);
            if(userExists != null)
            {
              Console.WriteLine("user profile already exist");
                return null;
            }
            else
            {
                User user = new User(UserDatabase.Count + 1,false, firstName,lastName,password, email,phoneNumber);
                UserDatabase.Add(user);
                return user;

            }
        }


        public User UpdateUser(string firstName, string lastName,string phoneNumber)
        {
             foreach (var user in UserDatabase)
            {
                if (user.FirstName == firstName && user.LastName == lastName && user.PhoneNumber == phoneNumber)
                {
                    return user;
                }
            }
            return null;
        }


          public User DeleteUser(string email)
        {
            var user = GetUser(email);
            if (user != null && user.IsDeleted == false)
            {
                user.IsDeleted = true;
            }
            Console.WriteLine("user not found or deleted");
            return null;
        }
         

        private User GetUsers(string email)
        {
            foreach (var user in UserDatabase)
            {
                if(user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

      
    }
}