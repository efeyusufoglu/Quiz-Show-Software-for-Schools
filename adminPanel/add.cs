using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adminPanel
{
    public partial class add : Form
    {
        classAdmin cA = new classAdmin();
        
        private void save()
        {   
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Questions (questionNo,time,point,question,correctAnswer,optionA,optionB,optionC,optionD) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", conn);
            cmd.Parameters.AddWithValue("@p1",txtNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtTime.Text);
            cmd.Parameters.AddWithValue("@p3", txtPoint.Text);
            cmd.Parameters.AddWithValue("@p4", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@p6", txtA.Text);
            cmd.Parameters.AddWithValue("@p7", txtB.Text);
            cmd.Parameters.AddWithValue("@p8", txtC.Text);
            cmd.Parameters.AddWithValue("@p9", txtD.Text);
            cmd.Parameters.AddWithValue("@p5", lblCorrectAnswer.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            clean();
        }
        private void clean()
        {
            txtNo.Clear();
            txtTime.Clear();
            txtTime.Clear();
            txtPoint.Clear();
            txtQuestion.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
        public add()
        {
            InitializeComponent();
        }
        
        private void add_Load(object sender, EventArgs e)
        {

        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {
            lblCorrectAnswer.Text = "A";
        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {
            lblCorrectAnswer.Text = "B";

        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {
            lblCorrectAnswer.Text = "C";

        }

        private void rdbD_CheckedChanged(object sender, EventArgs e)
        {
            lblCorrectAnswer.Text = "D";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
