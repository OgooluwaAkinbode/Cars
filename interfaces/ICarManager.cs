using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.models;

namespace CarSalesApp.interfaces
{
    public interface ICarManager
    {
        public void GetAllCars();
        public void AddCars(string name, int model, decimal price, int quantity);
        public string BuyCars(int id);
        public void BuyCar(int id);
    }
}