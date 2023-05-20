using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collage
{
    // класс администрация техникума
    class Administration
    {
        // Нанять учителя
        public void HireTeacher(TeacherDB teacher, string name, string surname, string gender, DateTime da) 
        {
            teacher.test.Add(new Teacher { Name = name, Surname = surname, Gender = gender, BirthDate = da, SickLeave = "Нет", Id = teacher.GetSumPerson() + 1 });
        }

        // Уволить учителя
        public void FireTeacher(TeacherDB teacher, int index)
        {
            teacher.test.RemoveAt(index);

            int temp = teacher.GetSumPerson();
            for (int i = 0; i < temp; i++)
            {
                teacher.test[i].Id = i + 1;
            }
        }

        // Зачислить студента
        public void EnrollStudent(StudentDB student, string name, string surname, string gender, DateTime da)
        {
            student.test.Add(new Student { Name = name, Surname = surname, Gender = gender, BirthDate = da, SubjectKnowledge = 10, SickLeave = "Нет", Id = student.GetSumPerson() + 1 });
            
        }

        // Отчислить студента
        public void ExpelStudent(StudentDB student, int index)
        {
            student.test.RemoveAt(index);

            int temp = student.GetSumPerson();
            for(int i = 0; i < temp; i++)
            {
                student.test[i].Id = i + 1;
            }
        }
    }
}
