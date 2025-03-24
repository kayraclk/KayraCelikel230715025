using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayraCelikel230715025MidTerm
{
    public partial class frmStudentGrade : Form
    {
        public frmStudentGrade()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new String[] { "A", "B", "C","D", "F" });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTextEditor editor = new frmTextEditor();
            editor.Show();

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBackGroundColorControl editor = new frmBackGroundColorControl();
            editor.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"You selected grade:{comboBox1.SelectedItem}"; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else(MessageBox.Show("Please selected grade: ")){

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItems);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
