using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.interfaces;
using CarSalesApp.models;

namespace CarSalesApp.implementations
{
    public class SuperAdminManager : ISuperAdminManager
    {
        public static List<SuperAdmin> superAdminDatabase = new List<SuperAdmin>{
            new SuperAdmin(1,false, 1,"SuperAdmin"),
        };
        IUserManager userManager = new UserManager();
        public SuperAdmin Get(string email)
        {
            foreach (var superAdmin in superAdminDatabase)
            {
                var user = userManager.GetUser(email);
                if (user.Id == superAdmin.UserId)
                {
                    return superAdmin;
                }
            }
            return null;
        }

        public void UpdateSuperAdmin(string email, string firstName, string lastName, string phoneNumber)
        {
            var user = userManager.GetUser(email);
            if (user != null)
            {
                user.FirstName = firstName;
                user.LastName = lastName;
                user.PhoneNumber = phoneNumber;
                Console.WriteLine($"You have updated your details successfully");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}