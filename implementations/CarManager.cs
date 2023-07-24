using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApp.interfaces;
using CarSalesApp.models;

namespace CarSalesApp.implementations
{
    public class CarManager : ICarManager
    {
        ICustomerManager customerManager = new CustomerManager();
        Manager manager = new Manager(1,false, 2, "Manager", 0);
        public static List<Car> carsDatabase = new List<Car>(){
            new Car(1,"Toyota", 200000, 2020,2,true),
            new Car(2,"Mercedes-benz", 10000000, 2021,5,true),
            new Car(3, "mitsubishi", 10000000,2030,5,true),
         };


        public void AddCars(string name, int model, decimal price, int quantity)
        {
            var carExists = GetCar(name, model);
            if (carExists != null)
            {
                carExists.Quantity += quantity;
            }
            else
            {
                var car = new Car(carsDatabase.Count + 1, name, price, model, quantity, true);
                carsDatabase.Add(car);
                Console.WriteLine($"{car.Name} was added successfully");
            }
        }

        public void BuyCar(int id)
        {
            Car car = GetCar(id);
            if (car.Id == id && car.IsAvailable == true)
            {
                decimal price = car.Price;
                //    decimal managerFee= 0.1m * price;
                //    decimal totalPrice= managerFee + price;
                Console.WriteLine($"The selling price of the car is : {price}");
                Console.WriteLine("Do you still want to buy car?\n Enter 1- yes \n2-  no");
                Console.WriteLine("Do you still want to buy car?\n Enter 1- yes \n2-  no");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("input your email:");
                        string email = Console.ReadLine();
                        Customer customer = customerManager.Get(email);
                        if (customer.Wallet > price)
                        {
                            customer.Wallet -= price;
                            manager.Wallet += price;
                            Console.WriteLine($"Your new wallet is {customer.Wallet}");
                            Console.WriteLine("Purchased successful");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("This property is not for sale");
            }

        }


        public string BuyCars(int id)
        {
            Car car = default;
            foreach (var item in carsDatabase)
            {
                if (item.Id == id && item.IsAvailable == true)
                {
                    car = item;
                    break;
                }
            }
            if (car == null)
            {
                return $"The car with {id} not found";
            }
            car.IsAvailable = false;
            return $"You have successfully purchased the car {car.Name}";

        }

        public void GetAllCars()
        {
            foreach (var car in carsDatabase)
            {
                if (car.IsAvailable == true)
                {
                    Console.WriteLine($"{car.Id}\t{car.Name}\t{car.Model}\t{car.Price}\t{car.Quantity}");
                }
            }
        }




        private Car GetCar(string Name, int model)
        {
            foreach (Car car in carsDatabase)
            {
                if (car.Name == Name && car.Model == model && car.IsAvailable == true)
                {
                    return car;
                }
            }
            return null;
        }
        private Car GetCar(int id)
        {
            foreach (Car car in carsDatabase)
            {
                if (car.Id == id && car.IsAvailable == true)
                {
                    return car;
                }
            }
            return null;
        }

    }

}
