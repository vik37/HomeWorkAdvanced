using Exemple.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exemple.Entities
{
    public class Student : User,IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();

        public void ShowGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
