using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class BaseEntity
    {
            public int Id { get; set; }
            public bool IsDeleted { get; set; }

            public BaseEntity(int id, bool isDeleted)
            {
                Id = id;
                IsDeleted = isDeleted;
            }
        
    }
}