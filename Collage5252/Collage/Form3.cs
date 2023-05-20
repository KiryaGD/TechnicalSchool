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
    public partial class Form3 : Form
    {
        
        StudentDB stdb;
        TeacherDB tdb;
        public Form3(StudentDB f1, TeacherDB f2)
        {
            stdb = f1;
            tdb = f2;
            InitializeComponent();

            dataGridView1.DataSource = stdb.test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            stdb.SetGrade();
            dataGridView1.Show();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = tdb.test;
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
