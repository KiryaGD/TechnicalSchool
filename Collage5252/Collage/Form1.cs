using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(fdb, tdb); // создаем
            f.ShowDialog(); // показываем
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(fdb, tdb); 
            f.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        StudentDB fdb = new StudentDB();

        TeacherDB tdb = new TeacherDB();
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(fdb); 
            f.ShowDialog(); 
        }
    }
}
