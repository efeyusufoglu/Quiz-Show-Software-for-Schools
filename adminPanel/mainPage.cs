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
    public partial class mainPage : Form
    {
        
        public mainPage()
        {
            InitializeComponent();
        }
        classAdmin cA = new classAdmin();
        private void refreshCmbSelectQuestion()
        {
            cmbSelectQuestion.Items.Clear();
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select questionNo From Tbl_Questions", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSelectQuestion.Items.Add(dr["questionNo"]);
            }
            conn.Close();
        }
        private void delete()
        {
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete From Tbl_Questions where questionNo=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", lblSelectedQuestions.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            fillDataGridView1();
            lblSelectedQuestions.Text = "-";
        }
        private void fillDataGridView1()
        {
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select questionNo,time,point,question,correctAnswer,optionA,optionB,optionC,optionD From Tbl_Questions", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            lblSelectedQuestions.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update sendedQuestion set sendedQuestion=@p1", conn);
            cmd.Parameters.AddWithValue("@p1",cmbSelectQuestion.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            cmbSelectQuestion.SelectedItem = null;
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Update Tbl_check set [check]=@p2", conn);
            cmd1.Parameters.AddWithValue("@p2", 1);
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Update Tbl_checkQuestion Set pointA=" + 0 + ",pointB=" + 0 + ",pointC=" + 0 + ",pointD=" + 0 + "", conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Update Tbl_check set [check]=@p1", conn);
            cmd1.Parameters.AddWithValue("@p1",0);
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Update Tbl_checkQuestion Set pointA=" + 0 + ",pointB=" + 0 + ",pointC=" + 0 + ",pointD=" + 0 + "", conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        private void resetPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cA.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Point set pointA=@p1, pointB=@p1, pointC=@p1, pointD=@p1", conn) ;
            cmd.Parameters.AddWithValue("@p1",0);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //refreshCmbSelectQuestion();
            //this.tbl_QuestionsTableAdapter.Fill(this.quizShowDataSet.Tbl_Questions);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshCmbSelectQuestion();
            fillDataGridView1();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPage_Load(object sender, EventArgs e)
        {

            fillDataGridView1();

        }
    }
}
