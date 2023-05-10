using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //logic of the task number 1
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Car car1 = new Car();
            //Console.Write("Enter brand of car 1: ");
            //car1.Brand = Console.ReadLine();
            //Console.Write("Enter model of car 1: ");
            //car1.Model = Console.ReadLine();
            //Console.Write("Enter registration number of car1: ");
            //car1.RegistrationNumber = Console.ReadLine();
            //Console.Write("Enter year of production of your car {after 2000 is eco below is not eco!}: ");
            //car1.YearofProduction = int.Parse(Console.ReadLine());
            //Car car2 = new Car();
            //Console.Write("Enter brand of car 1: ");
            //car2.Brand = Console.ReadLine();
            //Console.Write("Enter model of car 1: ");
            //car2.Model = Console.ReadLine();
            //Console.Write("Enter registration number of car1: ");
            //car2.RegistrationNumber = Console.ReadLine();
            //Console.Write("Enter year of production of your car {after 2000 is eco below is not eco!}: ");
            //car2.YearofProduction = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------------------------");
            //car1.Move();
            //car1.IfEcoFriendly();
            //car1.Introduction();
            //Console.WriteLine();
            //car2.Move();
            //car2.IfEcoFriendly();
            //car2.Introduction();
            //Console.WriteLine("---------------------------------------------------------------");
            //int numberOfParticipants = 2;
            //Console.WriteLine($"The number of participants is {numberOfParticipants}");

            //logic of the task number 2

            // Console.Write("Enter number of cars in the race: ");
            //int n = int.Parse(Console.ReadLine());
            //counter = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Car car = new Car();
            //    Console.Write("Enter brand of car: ");
            //    car.Brand = Console.ReadLine();
            //    Console.Write("Enter model of car: ");
            //    car.Model = Console.ReadLine();
            //    Console.Write("Enter registration number of the car: ");
            //    car.RegistrationNumber = Console.ReadLine();
            //    Console.Write("Enter year of production of  car {after 2000 is eco, below is not eco!}: ");
            //    car.YearofProduction = int.Parse(Console.ReadLine());
            //    Console.WriteLine("---------------------------------------------------------------");
            //    car.Move();
            //    car.IfEcoFriendly();
            //    car.Introduction();
            //    Console.WriteLine("---------------------------------------------------------------");
            //    counter++;
            //}
            //Console.WriteLine($"Number of participants in the race!!!: {counter}");

            //Console.WriteLine($"The number of participants in the race is: {Car.Count}");

            //logic 3 - the best one yet

            List<Car> list = new List<Car>();
            Console.Write("Enter number of cars: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter model: ");
                string model = Console.ReadLine();
                Console.Write("Enter registration number of car: ");
                string registrationnumber = Console.ReadLine();
                Console.Write("Enter year of production of your car {after 2000 is eco below is not eco!}: ");
                int year = int.Parse(Console.ReadLine());
                Car car = new Car(brand, model, registrationnumber, year);
                list.Add(car);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var example in list)
            {
                example.Move();
                example.IfEcoFriendly();
                example.Introduction();
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The number of participants in the race is: {Car.Count}!!!");
            Console.WriteLine();
        }
    }
}
