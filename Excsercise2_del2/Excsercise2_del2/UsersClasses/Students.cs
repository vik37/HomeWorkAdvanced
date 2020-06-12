using Excsercise2_del2.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Excsercise2_del2.UsersClasses
{
    public class Students : Users
    {
       public int SumOfPoints{ get; set; }


        private int Grade { get; set; } 
        public Students()
        {
           
           
        }
        public Students(int sumOfPoints,string userName, string password) : base(userName, password)
        {
            SumOfPoints = sumOfPoints;
        }
        //public int SetGrade()
        //{
        //   // int count = 0;
        //    //while(count < SumOfPoints)
        //    //{
        //        if (SumOfPoints > 0 || SumOfPoints < 5)
        //        {
        //            return Grade = 1;
        //        }
        //        else if (SumOfPoints > 5 || SumOfPoints < 10)
        //        {
        //            return Grade = 2;
        //        }
        //        else if (SumOfPoints > 10 || SumOfPoints < 13)
        //        {
        //            return Grade = 3;
        //        }
        //        else if (SumOfPoints > 13 || SumOfPoints < 16)
        //        {

        //            return Grade = 4;
        //        }
        //        else if (SumOfPoints > 16 || SumOfPoints <= 16)
        //        {
        //            return Grade = 5;
        //        }
        //        else
        //        {
        //            return Grade = 0;
        //        }
        //    //}
        //    //return Grade;

        //}
        //public int ReturnGrade(Teachers teacher)
        //{
        //    return Grade = teacher.SetGrade;
        //}
        public void ShowGrade()
        {
            if(Grade != 0)
            {
                Console.WriteLine($"GRADE: {Grade}");
            }
            else
            {
                Console.WriteLine($"");
            }
           
        }
       
        public int SetPoints(int num)
        {
            return SumOfPoints = num;
        }
        //public void ShowGrades()
        //{
        //    SetGrade();
        //    Console.WriteLine($"Grade: {Grade}");
        //}
       
    }
}
