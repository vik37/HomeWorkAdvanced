using Excsercise2_del2.Modules;
using Excsercise2_del2.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Excsercise2_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Students();
            var teachers = new Teachers();
            string inputStudentUser;
            string inputStudentPassword;
            string inputTeachUser;
            string inputTeachPassword;
            int someNum;
            bool isNum;
            logout:
            Console.WriteLine("Choise 1 for Student, 2 for Teachers");
            Console.WriteLine("--------------------------------------");
            var dataBaseStudents = DataBase.GetAllStudents();
            dataBaseStudents.Add(students);
            var dataBaseTeachers = DataBase.GetAllTeachers();
            dataBaseTeachers.Add(teachers);
            isNum = int.TryParse(Console.ReadLine(), out someNum);
            while (isNum)
            {
                if (someNum == 1)
                {
                        Console.WriteLine("User Name: ");
                        Console.WriteLine("____________________");
                        inputStudentUser = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        Console.WriteLine("____________________");
                        inputStudentPassword = Console.ReadLine();
                        students.UserName = inputStudentUser;                        
                        students.Password = inputStudentPassword;
                   
                        isNum = true;
                    break;
                }                
                else if (someNum == 2)
                {

                   
                        Console.WriteLine("User Name: ");
                        Console.WriteLine("____________________");
                        inputTeachUser = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        Console.WriteLine("____________________");
                        inputTeachPassword = Console.ReadLine();
                    teachers.UserName = inputTeachUser;
                    teachers.Password = inputTeachPassword;
                        isNum = true;

                    goto teacherPart;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR - must input only 1 or 2");
                    Console.ResetColor();
                    isNum = false;
                }
            }

            Console.WriteLine("Sing in is succesifully. Press enter for log in");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadLine();
            var ThreeTimes = Authentication.ThreeTimes;
            string logInStudents;
            string logPassStudents;
            Console.WriteLine("LOG IN");
            //var data = new DataBase();
            while (ThreeTimes)
            {
            
                Console.WriteLine("____________________");
                Console.WriteLine("Enter your user name: ");
                logInStudents = Console.ReadLine();
                              
                Console.WriteLine("____________________");
                Console.WriteLine("Enter your password: ");
                logPassStudents = Console.ReadLine();
                if (logInStudents == students.UserName || logPassStudents == students.Password)
                {
                    goto another;
                }
            }

        
        another:
            Console.WriteLine("Log in is succesifully.");
            Console.WriteLine("-----------------------------------------------");
            dataBaseStudents.ForEach(p => Console.WriteLine($"Student: {p.UserName}"));
            Console.WriteLine("Press Enter and start the test. GOOD LUCK");
            Console.ReadLine();
            int choiceNum;
            var authentication = new Authentication();
            Console.WriteLine("TEST: You have 5 Question with 4 answare and 1 is true you must enter the number of true answare");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------");
            Console.ReadLine();

            Console.WriteLine("QUESTION: 1 \n Points: 2");
            Questions.ShowFirst();                     
            authentication.ShowAnsware(1);                       
            Console.WriteLine("------------------------------------------");
            choiceNum = int.Parse(Console.ReadLine());
            DataBase.FirstQuestPounts(choiceNum);

            Console.WriteLine("QUESTION: 2 \n Points: 4");
            Questions.ShowSecond();
            authentication.ShowAnsware(2);
            Console.WriteLine("------------------------------------------");
            choiceNum = int.Parse(Console.ReadLine());
            DataBase.SecondtQuestPounts(choiceNum);

            Console.WriteLine("QUESTION: 3 \n Points: 3");
            Questions.ShowThird();
            authentication.ShowAnsware(3);
            Console.WriteLine("------------------------------------------");
            choiceNum = int.Parse(Console.ReadLine());
            DataBase.ThirdQuestPounts(choiceNum);

            Console.WriteLine("QUESTION: 4 \n Points: 5");
            Questions.ShowForth();
            authentication.ShowAnsware(4);
            Console.WriteLine("------------------------------------------");
            choiceNum = int.Parse(Console.ReadLine());
            DataBase.FourthQuestPounts(choiceNum);           

            Console.WriteLine("QUESTION: 5 \n Points: 4");
            Questions.Showifth();            
            authentication.ShowAnsware(5);
            Console.WriteLine("------------------------------------------");
            choiceNum = int.Parse(Console.ReadLine());
            DataBase.FifthQuestPounts(choiceNum);

         
            Console.WriteLine("You Have: {0} - Points",DataBase.Points);
            //int a = DataBase.Points;
            //students.SumOfPoints = a;
            students.SetPoints(DataBase.Points);

            
            Console.WriteLine(students.SumOfPoints);
            Console.WriteLine("Thank you about finish your test. The teacher will publish the grades in a few days");
            Console.WriteLine("Log Out");
            

            Console.ReadLine();
            goto logout;

          
        teacherPart:
            string logInTeachers;
            string logPassTeachers;
            Console.WriteLine("Sing in is succesifully. Press enter for log in");
            Console.WriteLine("-----------------------------------------------");
            while (Authentication.ThreeTimes)
            {

                Console.WriteLine("____________________");
                Console.WriteLine("Enter your user name: ");
                logInTeachers = Console.ReadLine();


                Console.WriteLine("____________________");
                Console.WriteLine("Enter your password: ");
                logPassTeachers = Console.ReadLine();
                if (logInTeachers == teachers.UserName || logPassTeachers == teachers.Password)
                {
                    break;
                }
            }
            Console.WriteLine("Welcome teacher {0}", teachers.UserName);
            Console.WriteLine("List of students with a completed and unfinished exam (PRESS ENTER)");
            Console.WriteLine("__________________________________________________________");
            Console.ReadLine();
            teachers.ShowStudentFinishTest();
            Console.WriteLine("--------------------------------------");
            teachers.ShowStudentNotFinishTEst();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" (0 - 5)Points: Grade 1 \n (5 - 9)Points: Grade 2 \n" +
                "(9 - 13)Points: Grade 3 \n (13 - 16)Points: Grade 4 \n" +
                "(16 - 18)Points: Grade 1 \n " +
                " Enter Grade ");
            Console.WriteLine("-----------------------------------------------");
            int grade = int.Parse(Console.ReadLine());
            teachers.SetGrade = grade;

            students.ShowGrade();


            Console.ReadLine();
        }
    }
}
