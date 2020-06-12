using System;
using System.Collections.Generic;
using System.Text;

namespace Excsercise2_del2.Modules
{
    public class Users
    {
        private int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Users()
        {

        }
        public Users(string userName, string password)
        {
            
            UserName = userName;
            Password = password;
        }

        private int RandomId()
        {
            Random randomNum = new Random();
            Id = randomNum.Next(1, 10);
            return Id;
        }
        public void ShowId()
        {
            Console.WriteLine($"User Name: {UserName}, Id: {Id}");
        }
       
    }
}
