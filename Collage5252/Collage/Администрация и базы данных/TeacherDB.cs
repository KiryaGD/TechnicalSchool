using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage
{
    public class TeacherDB
    {

        // Код схожий с StudentDB
        public ObservableCollection<Teacher> test { get; set; } = new ObservableCollection<Teacher>();

        public TeacherDB()
        {
            this.test.Add(new Teacher { Exam = "МДК", Name = "Виктор", Surname = "Горин", Gender = "Male", BirthDate = new DateTime(2004, 01, 01) });
            this.test.Add(new Teacher { Exam = "ОП", Name = "Сергей", Surname = "Иевлев", Gender = "Male", BirthDate = new DateTime(2004, 07, 27) });
            this.test.Add(new Teacher { Exam = "КГМ", Name = "Иван", Surname = "Тутов", Gender = "Male", BirthDate = new DateTime(2004, 01, 01) });

            int c = GetSumPerson();
            for (int i = 0; i < c; i++)
            {
                test[i].Id = i + 1;
            }
        }


        Administration adm = new Administration();
        public void AddTeacher(TeacherDB db, string name, string surname, string gender, DateTime da)
        {
            adm.HireTeacher(db, name, surname, gender, da);

        }

        public int GetSumPerson()
        {
            return test.Count();
        }

        public void DeleteTeacher(TeacherDB db, int index)
        {
            adm.FireTeacher(db, index);
        }

    }

}
