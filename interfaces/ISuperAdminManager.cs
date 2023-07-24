using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.models;

namespace CarSalesApp.interfaces
{
    public interface ISuperAdminManager
    {
        public void UpdateSuperAdmin(string email, string firstName, string lastName, string phoneNumber);
        public SuperAdmin Get(string email);
    }
}
