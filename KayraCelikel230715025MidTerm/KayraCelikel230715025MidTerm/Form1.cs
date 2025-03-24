using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KayraCelikel230715025MidTerm
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentGrade stu=new frmStudentGrade();
            stu.Show();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
     
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter ="Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
               txtContent.Text =File.ReadAllText(open.FileName);
                 
            }

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if(save.ShowDialog() == DialogResult.OK)
            {
               File.WriteAllText(save.FileName, txtContent.Text); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
