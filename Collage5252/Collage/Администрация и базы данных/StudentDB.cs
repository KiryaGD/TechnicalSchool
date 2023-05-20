using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collage
{
    public class StudentDB
    {
        // Коллекция классов "Student"
        public ObservableCollection<Student> test { get; set; } = new ObservableCollection<Student>();

        public StudentDB()
        {
            // Добавление трёх студентов
            test.Add(new Student { Grade = 0, SubjectKnowledge = 10, Name = "Kirill", Surname = "Boev", Gender = "Male", BirthDate = new DateTime(2004, 07, 29), SickLeave = "Нет" });
            test.Add(new Student { Grade = 0, SubjectKnowledge = 5, Name = "Sergey", Surname = "Ievlev", Gender = "Male", BirthDate = new DateTime(2004, 07, 27), SickLeave = "Нет" });
            test.Add(new Student { Grade = 0, SubjectKnowledge = 2, Name = "Vlad", Surname = "Boev", Gender = "Male", BirthDate = new DateTime(2004, 07, 29), SickLeave = "Нет" });

            // Присвоение Айди студентам
            int c = GetSumPerson();
            for(int i = 0; i < c; i++)
            {
                test[i].Id = i+1;
            }
        }

        // Узнать количество студентов в коллекции
        public int GetSumPerson()
        {
            return test.Count();
        }

        // Выставление больничного
        public void SetSickLeave(int name, bool b) // Переменная b определяет,
                                                   // выставить больничный или нет.
                                                   // Сделали для того, чтобы не дублировать код для обеих кнопок
        {
            int c = GetSumPerson();

            for(int i = 0; i < c; i++)
            {
                if (test[i].Id == name) 
                {
                    if (b == true)
                    {
                        test[i].SickLeave = "На больничном";
                        break;
                    }
                    else if(b == false)
                    {
                        test[i].SickLeave = "Нет";
                        break;
                    }
                }
            }
        }
        

        Teacher tea = new Teacher();
        public void SetGrade() // Установить оценку
        {
            int c = GetSumPerson();
            
            for(int i = 0; i < c; i++)
            {
                test[i].Grade = tea.ConductExam(test[i]);
            }
        }

        Administration adm = new Administration(); 
        
        // Зачислить студента
        public void AddStudent(StudentDB db, string name, string surname, string gender, DateTime da)
        {
            adm.EnrollStudent(db, name, surname, gender, da);

        }
        // Отчислить студента
        public void DeleteStudent(StudentDB db, int index)
        {
            adm.ExpelStudent(db, index);
        }

    }
}
