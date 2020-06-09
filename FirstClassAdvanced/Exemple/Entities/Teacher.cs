using System;
using System.Collections.Generic;
using System.Text;

namespace Exemple.Entities
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();
        public Student students;
        public Dictionary<List<string>, List<int>> subjectWithGrades { get; set; } = new Dictionary<List<string>, List<int>>();
        public Teacher()
        {
           
        }

        public void PrintSubject()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        
        }

        public void PrintSubjectsWithGrades()
        {
            foreach (KeyValuePair<List<string>,List<int>> subject in subjectWithGrades)
            {
                Console.WriteLine("Subjects - | - Grades");
                Console.WriteLine("--------------------");
                foreach (var item in subject.Key)
                {
                    foreach (var grade in subject.Value)
                    {
                        Console.WriteLine($"{item}   -  |   - {grade}");
                        break;
                    }
                    
                }

               // Console.WriteLine("Subjects:");
               //subject.Key.ForEach(s => Console.Write($"{s} \n "));
               // Console.WriteLine("Grades:");
               // subject.Value.ForEach(s => Console.Write($"{s} \n "));

            }
        }

       
    }
}
