using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace competitorScreen
{
    public partial class classSelect : Form
    {
        public static string sınıf;
        public classSelect()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked == true) { sınıf = "A"; }
            else if (rdbB.Checked == true) { sınıf = "B"; }
            else if (rdbC.Checked == true) { sınıf = "C"; }
            else if (rdbD.Checked == true) { sınıf = "D"; }
            mainPage form1 = new mainPage();
            form1.Show();
            this.Hide();
        }

        
    }
}
