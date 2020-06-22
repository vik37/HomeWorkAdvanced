using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public abstract class Wheecles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Wheecles()
        {
            Id = Id + 1;
        }
        public Wheecles(int id, string name, string type, string color)
        {
            Id = id;
            Name = name;
            Type = type;
            Color = color;
        }
        public abstract void ShowInfo();
        public int returnId()
        {
            Random ran = new Random();
            Id = ran.Next(1, 23);
            return Id;
        }
    }
}
