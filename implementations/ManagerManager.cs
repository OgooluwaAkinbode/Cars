using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.interfaces;
using CarSalesApp.models;

namespace CarSalesApp.implementations
{
    public class ManagerManager : IManagerManager
    {
        public static List<Manager> managerDatabase = new List<Manager>(){
            new Manager(1,false,2,"Manager", 0),
         };
        IUserManager userManager = new UserManager();
        public Manager DeleteManager(int userId)
        {
            foreach (var manager in managerDatabase)
            {
                var user = userManager.GetUser(userId);
                if (manager.UserId == userId)
                {
                    managerDatabase.Remove(manager);
                }
            }
            return null;
        }

        public void GetAllManager()
        {
            foreach (var manager in managerDatabase)
            {
                if (manager.Role == "Manager")
                {
                    var user = userManager.GetUser(manager.UserId);
                    Console.WriteLine($"{user.Id}\t{user.FirstName}\t{user.LastName}\t{user.Email}\t{user.PhoneNumber}");

                }
            }
        }

        public Manager GetManager(int id)
        {
            foreach (var manager in managerDatabase)
            {
                if (manager.Id == id)
                {
                    return manager;
                }
            }
            return null;
        }

        public Manager Get(string email)
        {
            foreach (var manager in managerDatabase)
            {
                var user = userManager.GetUser(email);
                if (user.Id == manager.UserId)
                {
                    return manager;
                }
            }
            return null;
        }

        public void RegisterManager()
        {
            var manager = new Manager(managerDatabase.Count + 1,false, UserManager.UserDatabase.Count, "Manager", 0);
            managerDatabase.Add(manager);
            var user = userManager.GetUser(manager.UserId);
            Console.WriteLine($"Congrats mr/mrs {user.FirstName} {user.LastName}, you have registered successfully");
        }

        public Manager UpdateManager(string email)
        {
            foreach (var manager in managerDatabase)
            {
                var user = userManager.GetUser(email);
                if (user.Email == email)
                {
                    return manager;
                }
            }
            return null;
        }


    }
}