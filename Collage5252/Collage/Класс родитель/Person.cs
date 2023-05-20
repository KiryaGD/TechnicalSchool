using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage
{
    // базовый класс "человек"
    public class Person
    {
        
        public string Name { get; set; } // Имя
        public string Surname { get; set; } // Фамилия
        public DateTime BirthDate { get; set; } // Дата рождения
        public string Gender { get; set; } // Пол
        public string SickLeave { get; set; } // Больничный
        public int Id { get; set; } // Айди
        
    }
}
