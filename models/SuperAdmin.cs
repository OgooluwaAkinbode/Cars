using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class SuperAdmin : BaseEntity
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        public SuperAdmin(int id,bool isDeleted, int userId, string role) : base(id, isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
            UserId = userId;
            Role = role;
        }

        
    }
}