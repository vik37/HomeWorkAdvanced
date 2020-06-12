
using Excsercise2_del2.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using Excsercise2_del2.UsersClasses;

namespace Excsercise2_del2
{
    public class Authentication
    {
        
        public static bool ThreeTimes = true;
        public Authentication()
        {

        }

       public static bool ThreeTimeTroo()
        {
            int num = 0;
            while (num < 4)
            {
                if(num == 3)
                {
                    return ThreeTimes = false;
                    
                }
            }
            return true;
        }
        
        public void ShowAnsware(int num)
        {
            // var quezz = Quezz.ShowAnsware(num);
            var quezz = new Quezz();
            //var quezzOne = quezz.ShowAnsware();
            foreach (KeyValuePair<int,string> answare in quezz.GetAnsware(num))
            {
                Console.WriteLine($"{answare.Key} {answare.Value}");
            }
           
        }
        
       


    }
}
