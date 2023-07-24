using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class Customer : BaseEntity
    {
       
        public int UserId{get;set;}
        public string Role{get;set;}
        public decimal Wallet{get;set;}
        public Customer(int id,bool isDeleted, int userId, string role, decimal wallet) : base(id,isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
            UserId = userId;
            Role = role;
            Wallet = wallet;
        }

       
    }
}