using HomeWork_SerialieDeserialize.Entities;
using HomeWork_SerialieDeserialize.Services;
using System;
using System.IO;
using Newtonsoft.Json;

namespace HomeWork_SerialieDeserialize
{
    class Program
    {
        public static string directoryPath = Directory.GetCurrentDirectory();
        public static string filePath = Path.Combine(directoryPath, "DogJson.json");
        public static string textFilePAth = Path.Combine(directoryPath, "DogsText.txt");
        private static Serialize serialize;
        public static ReadWrite rw;
       
        static void Main(string[] args)
        {
            serialize = new Serialize();
            rw = new ReadWrite();
            Console.WriteLine("Enter Dog's name");
            string dogName = Console.ReadLine();
            Console.WriteLine("--------------------------");

            Console.WriteLine("Enter Dog's age");
            int dogAge = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            Console.WriteLine("Enter Dog's color");
            string dogColor = Console.ReadLine();
            Console.WriteLine("--------------------------");

            Dog dog1 = new Dog()
            {
                Name = dogName,
                Age = dogAge,
                Color = dogColor
            };

            string firstDogJson = serialize.SerializeDog(dog1);
            rw.WriteFile(filePath, firstDogJson);

            Dog newtownOfDog = JsonConvert.DeserializeObject<Dog>(firstDogJson);
            rw.WriteFile(textFilePAth, $"Name: {newtownOfDog.Name}, Age: {newtownOfDog.Age}, Color: {newtownOfDog.Color}");
            string readText = rw.ReadFile(textFilePAth);
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}
