using ConsoleApp1.Entities;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static DataBase<Truck> TruckDb = new DataBase<Truck>();
        public static DataBase<Car> CarDb = new DataBase<Car>();
        static void Main(string[] args)
        {
            TruckDb.Insert(new Truck() { Name = "Mercedes-Benz", Type = "Actros", Color = "Red and White", Weight = 18000.96M});
            TruckDb.Insert(new Truck() { Name = "Mack", Type = "Super-Liner", Color = "White", Weight = 31752.08M });
            TruckDb.Insert(new Truck() { Name = "Isuzu", Type = "Elf", Color = "White and Black", Weight = 9600.43M });
            TruckDb.Insert(new Truck() { Name = "Mercedes-Benz", Type = "Sprinter", Color = "Blue Grey", Weight = 3629.27M });
            TruckDb.Insert(new Truck() { Name = "Kenwort", Type = "W900", Color = "Red", Weight = 56238.00M });

            CarDb.Insert(new Car() { Name = "Mercedes-Benz", Type = "Class-C", Color = "Black", MaxSpeed = 235 });
            CarDb.Insert(new Car() { Name = "Audi", Type = "R8", Color = "Grey", MaxSpeed = 324 });
            CarDb.Insert(new Car() { Name = "Mitsubishi", Type = "Lancer", Color = "White", MaxSpeed = 200 });
            CarDb.Insert(new Car() { Name = "Zastava", Type = "750", Color = "Black", MaxSpeed = 110 });

            
            

            #region stringAndDataExercise

            //string myNameIs = "My name; is Viktor Zafirovski, and i - am 37 years old. Maybe i can leave more";

            //string[] splitString = myNameIs.Split(new Char[] { '-'," " });


            //string subName = myNameIs.Substring(9, 27);

            //foreach (var text in splitString)
            //{
            //    Console.WriteLine(text);
            //}
            //for (int i = 0; i < splitString.Length; i++)
            //{
            //    Console.WriteLine($"{splitString[0].Substring(3,7)} ");
            //}
            //Console.WriteLine(subName);

            //string stringDate = "12/18/2002";
            //DateTime convertDate = DateTime.Parse(stringDate);
            //Console.WriteLine(stringDate);
            //DateTime currentDateTime = DateTime.Now;

            //DateTime addedYears = currentDateTime.AddYears(-5);
            //Console.WriteLine(addedYears);
            //int month = currentDateTime.Month;
            //Console.WriteLine(month);
            #endregion


            Console.ReadLine();
        }
    }
}
