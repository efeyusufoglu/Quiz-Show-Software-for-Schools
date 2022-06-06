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

namespace viewerPanel
{
    public partial class viewerPage : Form
    {
        classViewer cV = new classViewer();
        public static int selectedQuestion1, time, b, pointA,pointB,pointC,pointD;

        

        public viewerPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b==1 && time == 0){
                panel1.Visible = true;
                time = 0;
            }
            else if (time == 0)
            {
                time = 0;
                
            }
            
            else if (time > 0)
            {
                time--;
                panel1.Visible = false;
            }
            lblTime2.Text = time.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cV.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From sendedQuestion", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                selectedQuestion1 = Convert.ToInt32(dr["sendedQuestion"]);
            }
            conn.Close();
            if (lblNo2.Text != selectedQuestion1.ToString())
            {

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Tbl_Questions where questionNo=@p1", conn);
                cmd1.Parameters.AddWithValue("@p1", selectedQuestion1);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    lblNo2.Text = dr1["questionNo"].ToString();
                    time = Convert.ToInt32(dr1["Time"]);
                    txtQuestion.Text = dr1["question"].ToString();
                }
                conn.Close();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cV.connLink);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From Tbl_Point", conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                pointA = Convert.ToInt32(dr1["pointA"]);
                pointB = Convert.ToInt32(dr1["pointB"]);
                pointC = Convert.ToInt32(dr1["pointC"]);
                pointD = Convert.ToInt32(dr1["pointD"]);
            }
            conn.Close();
            chart2.Series.Clear();
            chart2.Series.Add("Score");
            chart2.Series["Score"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            chart2.Series["Score"].Points.AddXY("A", pointA);
            chart2.Series["Score"].Points.AddXY("B", pointB);
            chart2.Series["Score"].Points.AddXY("C", pointC);
            chart2.Series["Score"].Points.AddXY("D", pointD);
            lblPointA.Text = pointA.ToString();
            lblPointB.Text = pointB.ToString();
            lblPointC.Text = pointC.ToString();
            lblPointD.Text = pointD.ToString();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From Tbl_checkQuestion",conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                if (Convert.ToInt32(dr2["pointA"]) == 1)
                {
                    checkA.Text = "Correct";
                }
                else
                {
                    checkA.Text = "Wrong";
                }
                if (Convert.ToInt32(dr2["pointB"]) == 1)
                {
                    checkB.Text = "Correct";
                }
                else
                {
                    checkB.Text = "Wrong";
                }
                if (Convert.ToInt32(dr2["pointC"]) == 1)
                {
                    checkC.Text = "Correct";
                }
                else
                {
                    checkC.Text = "Wrong";
                }
                if (Convert.ToInt32(dr2["pointD"]) == 1)
                {
                    checkD.Text = "Correct";
                }
                else
                {
                    checkD.Text = "Wrong";
                }
            }
            conn.Close();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cV.connLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_check", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                b = Convert.ToInt32(dr["check"]);
            }
            conn.Close();
            if (b == 1)
            {
                timer2.Enabled = true;
            }
        }

        
    }
}
