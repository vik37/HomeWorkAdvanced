using Excsercise2_del2.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excsercise2_del2.UsersClasses
{
    public class Teachers : Users
    {
        public Students student;
        public int SetGrade { get; set; }
        public Teachers()
        {

        }
        public Teachers(string userName, string password) : base( userName,  password)
        {
           
        }
        public void ShowStudentFinishTest()
        {
            var allStudents = DataBase.GetAllStudents();
            var allStudentFinish = allStudents.Where(s => s.SumOfPoints != 0).Select(s => s).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            allStudentFinish.ForEach(a => Console.WriteLine($"Student: {a.UserName}, Points: {a.SumOfPoints}"));                       
        }
        public void ShowStudentNotFinishTEst()
        {
            var allStudents = DataBase.GetAllStudents();
            var allStudentNotFinish = allStudents.Where(s => s.SumOfPoints == 0).Select(s => s).ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            allStudentNotFinish.ForEach(a => Console.WriteLine(($"Student: {a.UserName}, Points: {a.SumOfPoints}")));
        }
       
        
    }
}
