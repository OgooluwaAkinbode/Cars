using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public User(int id,bool isDeleted, string firstName, string lastName, string password, string email, string phoneNumber) : base (id, isDeleted)
        {
            Id = id;
            IsDeleted= isDeleted;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }


          public override string ToString()
        {
            return $"{Id}\t{IsDeleted}\t{FirstName}\t{LastName}{Email}\t{PhoneNumber}";
        }

        public static User ToUser(string user)
        {
            var userSt= user.Split('\t');
            int id = int.Parse(userSt[0]);
            bool isDeleted= bool.Parse(userSt[1]);
            string firstName= userSt[2];
            string lastName = userSt[3];
            string password= userSt[4];
            string email = userSt[5];
            string phoneNumber = userSt[6];
            return new User(id, isDeleted,firstName, lastName, password, email, phoneNumber);
        }
    }
}