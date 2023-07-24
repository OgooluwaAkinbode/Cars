using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class Manager : BaseEntity
    {
    
        public int UserId { get; set; }
        public string Role { get; set; }
        public decimal Wallet { get; set; }
        public Manager(int id,bool isDeleted, int userId, string role, decimal wallet) : base(id, isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
            UserId = userId;
            Role = role;
            Wallet = Wallet;
        }


        
 
    }
}