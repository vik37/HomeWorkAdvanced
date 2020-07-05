using HomeWork_SerialieDeserialize.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_SerialieDeserialize.Services
{
    public class Serialize
    {
        public string SerializeDog(Dog dog)
        {
            string json = "{";
            json += $"\"Name\" : \"{dog.Name}\",";
            json += $"\"Age\" : \"{dog.Age}\",";
            json += $"\"Color\" : \"{dog.Color}\",";
            json += "}";

            return json;
        }
       
    }
}
