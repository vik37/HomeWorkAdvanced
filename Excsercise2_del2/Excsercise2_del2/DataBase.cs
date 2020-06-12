using System;
using System.Collections.Generic;
using System.Text;
using Excsercise2_del2.Modules;
using Excsercise2_del2.UsersClasses;


namespace Excsercise2_del2
{
    public class DataBase
    {
        public static int Points;
        public static List<Students> GetAllStudents()
        {
            return new List<Students>()
            {
                new Students(){UserName = "Mitko",Password = "1256mk",SumOfPoints = 0},
                new Students(){UserName = "Pako",Password = "mko32",SumOfPoints = 8},
                new Students(){UserName = "Angelina",Password = "Nema_veze",SumOfPoints = 0}                
            };
        }
        public static List<Teachers> GetAllTeachers()
        {
            return new List<Teachers>()
            {
                new Teachers(){UserName = "ALPachino",Password = "stroj25"},
                new Teachers(){UserName = "Kriss",Password = "gradina"},
                new Teachers(){UserName = "Asma",Password = "pajak"}
            };
        }
        public static int FirstQuestPounts(int choiceNum)
        {
            if(choiceNum == 2)
            {
                return Points = Points + 2;
            }
           return Points;
        }
        public static int SecondtQuestPounts(int choiceNum)
        {
            if (choiceNum == 4)
            {
                return Points = Points + 4;
            }
            return Points;
        }
        public static int ThirdQuestPounts(int choiceNum)
        {
            if (choiceNum == 4)
            {
                return Points = Points + 3;
            }
            return Points;
        }
        public static int FourthQuestPounts(int choiceNum)
        {
            if (choiceNum == 2)
            {
                return Points = Points + 5;
            }
            return Points;
        }
        public static int FifthQuestPounts(int choiceNum)
        {
            if (choiceNum == 1)
            {
                return Points = Points + 4;
            }
            return Points;
        }
    }
    
}
