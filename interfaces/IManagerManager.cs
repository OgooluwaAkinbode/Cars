using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.models;

namespace CarSalesApp.interfaces
{
    public interface IManagerManager
    {
     public void RegisterManager();
     public Manager DeleteManager(int userId);
     public Manager UpdateManager(string email);
      public  Manager GetManager(int id);
       public void GetAllManager();
      public Manager Get(string email);
    }
}