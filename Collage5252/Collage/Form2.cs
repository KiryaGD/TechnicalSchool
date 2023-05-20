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
    public partial class Form2 : Form
    {
        public Form2(StudentDB f1, TeacherDB t1)
        {
            stdb = f1;
            tdb = t1;

            InitializeComponent();
            //dataGridView1.DataSource = stdb.test;
        }

        StudentDB stdb;
        TeacherDB tdb;


        private void Form2_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = stdb.test;
            
            SetComboBox();

            dataGridView2.DataSource = tdb.test;
            
        }

        public void SetComboBox()
        {
            int c = stdb.GetSumPerson();
            for (int i = 0; i < c; i++)
            {
                comboBox1.Items.Add(stdb.test[i].Name);
            }
            try { 
            comboBox1.SelectedIndex = 0;
            }
            catch
            {
                comboBox1.Items.Add("Пусто");
                comboBox1.SelectedIndex = 0;
                button4.Enabled = false;
            }
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            int c2 = tdb.GetSumPerson();
            for (int i = 0; i < c2; i++)
            {
                comboBox2.Items.Add(tdb.test[i].Name);
            }
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch
            {
                comboBox2.Items.Add("Пусто");
                comboBox2.SelectedIndex = 0;
                button2.Enabled = false;
            }

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ClearComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;

            string name = textBox6.Text.ToString();
            string surname = textBox7.Text.ToString();
            string gender = textBox8.Text.ToString();
            DateTime da = dateTimePicker1.Value;
            
            stdb.AddStudent(stdb, name, surname, gender, da);

            RebootDataGridView();

        }

        public void RebootDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stdb.test;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = tdb.test;

            dataGridView1.Hide();
            dataGridView1.Show();

            dataGridView2.Hide();
            dataGridView2.Show();

            ClearComboBox();
            SetComboBox();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) {

            int temp = comboBox1.SelectedIndex;
            stdb.DeleteStudent(stdb, temp);

            RebootDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;

            string name = textBox1.Text.ToString();
            string surname = textBox2.Text.ToString();
            string gender = textBox3.Text.ToString();
            DateTime da = dateTimePicker2.Value;

            tdb.AddTeacher(tdb, name, surname, gender, da);

            RebootDataGridView();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = comboBox2.SelectedIndex;

            tdb.DeleteTeacher(tdb, temp);

            RebootDataGridView();
        }
    }
}
