using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApp.models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Model { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }


        public Car(int id, string name, decimal price, int model, int quantity, bool isAvailable)
        {
            Id = id;
            Name = name;
            Price = price;
            Model = model;
            Quantity = quantity;
            IsAvailable = isAvailable;
        }

       
    }
}