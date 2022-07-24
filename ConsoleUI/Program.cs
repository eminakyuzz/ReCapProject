using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car ID          : "+ car.Id);
                Console.WriteLine("Car Category ID : " + car.BrandId);
                Console.WriteLine("Car Color ID    : " + car.ColorId);
                Console.WriteLine("Car ID          : " + car.DailyPrice);
                Console.WriteLine("Car Description : " + car.Description);
                Console.WriteLine("--------------------------");
            }
        }
    }
}
