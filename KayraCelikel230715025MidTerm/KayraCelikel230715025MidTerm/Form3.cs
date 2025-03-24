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
    public partial class frmBackGroundColorControl : Form
    {
        public frmBackGroundColorControl()
        {
            InitializeComponent();
            UpgradeBackgroundColor();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {

        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main=new frmMain();
            main.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpgradeBackgroundColor();
        }
               private void UpgradeBackgroundColor()
        {
            int red = trackBar1.Value;
            int green = trackBar1.Value;   
            int blue= trackBar1.Value;  
            this.BackColor=Color.FromArgb(red, green, blue);
            label1.Text = $"Color: {red},{green},{blue}";

        }
        private void frmBackGroundColorControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpgradeBackgroundColor();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpgradeBackgroundColor();
        }
    }
}
