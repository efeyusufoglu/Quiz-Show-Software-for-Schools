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

namespace competitorScreen
{
    public partial class mainPage : Form
    {
        classCompetitor cC = new classCompetitor();
        private void savePoint()
        {
            SqlConnection conn = new SqlConnection(cC.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Point set " + classCompetitor.addPoint + " = @p2", conn);
            cmd.Parameters.AddWithValue("@p2", classCompetitor.totalPoint);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void getQuestion()
        {
            SqlConnection conn = new SqlConnection(cC.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select questionNo,Time,Point,question,optionA,optionB,optionC,optionD,correctAnswer From Tbl_Questions where questionNo=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", classCompetitor.questionNo);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lblQuestionNo.Text = dr1["questionNo"].ToString();
                txtQuestion.Text = dr1["question"].ToString();
                btnA.Text = dr1["optionA"].ToString();
                btnB.Text = dr1["optionB"].ToString();
                btnC.Text = dr1["optionC"].ToString();
                btnD.Text = dr1["optionD"].ToString();
                classCompetitor.answer = dr1["correctAnswer"].ToString();
                classCompetitor.time = Convert.ToInt32(dr1["Time"]);
                classCompetitor.point = Convert.ToInt32(dr1["Point"]);
            }

            conn.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = true;

            if (classCompetitor.answer == "A")
            {
                classCompetitor.totalPoint = classCompetitor.totalPoint + classCompetitor.point;

                savePoint();
                SqlConnection conn = new SqlConnection(cC.connLink);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_checkQuestion Set "+ classCompetitor.addPoint +"=" + 1 + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = true;
            if (classCompetitor.answer == "B")
            {
                classCompetitor.totalPoint = classCompetitor.totalPoint + classCompetitor.point;

                savePoint();
                SqlConnection conn = new SqlConnection(cC.connLink);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_checkQuestion Set " + classCompetitor.addPoint + "=" + 1 + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = true;
            if (classCompetitor.answer == "C")
            {
                classCompetitor.totalPoint = classCompetitor.totalPoint + classCompetitor.point;
                savePoint();
                SqlConnection conn = new SqlConnection(cC.connLink);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_checkQuestion Set " + classCompetitor.addPoint + "=" + 1 + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = true;
            if (classCompetitor.answer == "D")
            {
                classCompetitor.totalPoint = classCompetitor.totalPoint + classCompetitor.point;

                savePoint();
                SqlConnection conn = new SqlConnection(cC.connLink);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_checkQuestion Set " + classCompetitor.addPoint + "=" + 1 + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (classCompetitor.time == 0)
            {
                classCompetitor.time = 0;
                panel1.Visible = false;
                label7.Visible = true;
            }
            else if (classCompetitor.time > 0)
            {
                classCompetitor.time--;
            }
            lblTime.Text = classCompetitor.time.ToString();
            lblScore.Text = classCompetitor.totalPoint.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cC.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From sendedQuestion", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classCompetitor.a = Convert.ToInt32(dr["sendedQuestion"]);
            }
            conn.Close();
            if (classCompetitor.a != classCompetitor.questionNo)
            {
                classCompetitor.questionNo = classCompetitor.a;
                getQuestion();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cC.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_check", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classCompetitor.b = Convert.ToInt32(dr["check"]);
            }
            conn.Close();
            if (classCompetitor.b == 1)
            {
                timer2.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (classSelect.sınıf == "A") { classCompetitor.addPoint = "pointA"; }
            if (classSelect.sınıf == "B") { classCompetitor.addPoint = "pointB"; }
            if (classSelect.sınıf == "C") { classCompetitor.addPoint = "pointC"; }
            if (classSelect.sınıf == "D") { classCompetitor.addPoint = "pointD"; }
            lblClass.Text = classSelect.sınıf;
            SqlConnection conn = new SqlConnection(cC.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Point", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classCompetitor.totalPoint = Convert.ToInt32(dr[classCompetitor.addPoint]);
            }
            conn.Close();
        }
        public mainPage()
        {
            InitializeComponent();
        }

        private void lblQuestionNo_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
        }
    }
}
