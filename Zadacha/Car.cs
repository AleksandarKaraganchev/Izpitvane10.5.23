using System;
using System.Security.Policy;

namespace Zadacha
{
    public class Car
    {
		private string brand;
		private static int count;

		public static int Count
		{
			get { return count; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}
		private string model;
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private string registrationNumber;
		public string RegistrationNumber
		{
			get { return registrationNumber; }
			set { registrationNumber = value; }
		}
		private int yearofProduction;
		public int YearofProduction
        {
			get { return yearofProduction; }
			set { yearofProduction = value; }
		}
		public void Move()
		{
			Console.WriteLine($"[{this.Brand}] , [{this.Model}] Brym – brum -brum!!!");
		}
		public void IfEcoFriendly()
		{
			if (this.YearofProduction >= 2000)
			{
				Console.WriteLine("i'm a eco friendly car !!!:) [ECO]");
			}
			else
			{
				Console.WriteLine("I'm not a eco car :(");
			}
		}
		public void Introduction()
		{
			Console.WriteLine($"Brand: [{this.Brand}], Model: [{this.Model}], Registration number: [{this.RegistrationNumber}], Year of production: [{this.YearofProduction}]");
		}

		public Car(string brand, string model, string registrationnum, int yearofproduction)
		{
			this.brand = brand;
			this.model = model;
			this.registrationNumber = registrationnum;
			this.yearofProduction = yearofproduction;
			count++;
		}
	}
}
