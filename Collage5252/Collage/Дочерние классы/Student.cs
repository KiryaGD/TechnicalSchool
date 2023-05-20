using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage
{
    // класс студент, наследуется от класса "человек"
    public class Student : Person
    {
        public int SubjectKnowledge { get; set; } // Знания
        public int Grade { get; set; } // Оценка 

        public Student() { }

        public Student(int sk, int grade)
        {
            this.SubjectKnowledge = sk;
            this.Grade = grade;
        }

        public int GetGrade() // Получить оценку
        {
            return SubjectKnowledge;
        }


    }
}
