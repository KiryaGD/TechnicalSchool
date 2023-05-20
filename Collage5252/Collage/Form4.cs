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
    public partial class Form4 : Form
    {
        
        StudentDB stdb;

        public Form4(StudentDB f1)
        {
            stdb = f1;
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //StudentDB stdb = new StudentDB();

        private void Form4_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = stdb.test;
            
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

                button1.Enabled = false;
                button2.Enabled = false;
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void studentBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {

            //string temp = comboBox1.SelectedItem.ToString();
            int temp = comboBox1.SelectedIndex + 1;

            stdb.SetSickLeave(temp, true);
            
            dataGridView1.DataSource = stdb.test;
            RebootDataGridView();
          
        }
        private void Form4_Activated(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int temp = comboBox1.SelectedIndex + 1;
            stdb.SetSickLeave(temp, false);
            dataGridView1.DataSource = stdb.test;
            RebootDataGridView();
        }

        public void RebootDataGridView()
        {
            dataGridView1.Hide();
            dataGridView1.Show();
        }
    }
}
