using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage
{
    // класс преподаватель, наследуется от класса "человек"
    public class Teacher : Person
    {
        public string Exam { get; set; }

        public Teacher() { }

        public Teacher(string ex)
        {
            this.Exam = ex;
        }
        
        public int ConductExam(Student student) // Провести экзамен (заполнить колонку Grade в таблице студентов)
        {
            int temp = student.GetGrade();
            return CalculateGrade(temp);
            
        }

        private int CalculateGrade(int grade) // Оценка выставляется на основе показателя знаний, от 0 до 8+
        {
            if (grade <= 4)
            {
                return 2;
            }
            else if (grade > 4 && grade <= 6)
            {
                return 3;
            }
            else if (grade > 6 && grade <= 8)
            {
                return 4;
            }
            else if(grade > 8)
            {
                return 5;
            }

            return 0;
            
        }
    }
}