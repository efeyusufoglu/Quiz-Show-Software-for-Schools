namespace viewerPanel
{
    partial class viewerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkA = new System.Windows.Forms.Label();
            this.checkB = new System.Windows.Forms.Label();
            this.checkC = new System.Windows.Forms.Label();
            this.checkD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPointD = new System.Windows.Forms.Label();
            this.lblPointC = new System.Windows.Forms.Label();
            this.lblPointB = new System.Windows.Forms.Label();
            this.lblPointA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(343, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 24);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time Left:";
            // 
            // lblNo
            // 
            this.lblNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(180, 28);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(16, 24);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question Number:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(13, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(775, 155);
            this.textBox1.TabIndex = 7;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(184, 249);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(465, 221);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // lblTime2
            // 
            this.lblTime2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(330, 20);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(16, 24);
            this.lblTime2.TabIndex = 11;
            this.lblTime2.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time Left:";
            // 
            // lblNo2
            // 
            this.lblNo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNo2.AutoSize = true;
            this.lblNo2.Location = new System.Drawing.Point(180, 20);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(16, 24);
            this.lblNo2.TabIndex = 9;
            this.lblNo2.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Question Number:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuestion.Location = new System.Drawing.Point(13, 80);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(919, 155);
            this.txtQuestion.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(13, 252);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Score";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(540, 260);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
//            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Class A:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Class C:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Class D:";
            // 
            // checkA
            // 
            this.checkA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkA.AutoSize = true;
            this.checkA.Location = new System.Drawing.Point(103, 24);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(16, 24);
            this.checkA.TabIndex = 17;
            this.checkA.Text = "-";
            // 
            // checkB
            // 
            this.checkB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkB.AutoSize = true;
            this.checkB.Location = new System.Drawing.Point(103, 59);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(16, 24);
            this.checkB.TabIndex = 18;
            this.checkB.Text = "-";
            // 
            // checkC
            // 
            this.checkC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(103, 93);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(16, 24);
            this.checkC.TabIndex = 19;
            this.checkC.Text = "-";
            // 
            // checkD
            // 
            this.checkD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkD.AutoSize = true;
            this.checkD.Location = new System.Drawing.Point(103, 128);
            this.checkD.Name = "checkD";
            this.checkD.Size = new System.Drawing.Size(16, 24);
            this.checkD.TabIndex = 20;
            this.checkD.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.lblPointD);
            this.panel1.Controls.Add(this.lblPointC);
            this.panel1.Controls.Add(this.lblPointB);
            this.panel1.Controls.Add(this.lblPointA);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkA);
            this.panel1.Location = new System.Drawing.Point(603, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 182);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // lblPointD
            // 
            this.lblPointD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPointD.AutoSize = true;
            this.lblPointD.Location = new System.Drawing.Point(203, 128);
            this.lblPointD.Name = "lblPointD";
            this.lblPointD.Size = new System.Drawing.Size(16, 24);
            this.lblPointD.TabIndex = 26;
            this.lblPointD.Text = "-";
            // 
            // lblPointC
            // 
            this.lblPointC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPointC.AutoSize = true;
            this.lblPointC.Location = new System.Drawing.Point(203, 93);
            this.lblPointC.Name = "lblPointC";
            this.lblPointC.Size = new System.Drawing.Size(16, 24);
            this.lblPointC.TabIndex = 27;
            this.lblPointC.Text = "-";
            // 
            // lblPointB
            // 
            this.lblPointB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPointB.AutoSize = true;
            this.lblPointB.Location = new System.Drawing.Point(203, 59);
            this.lblPointB.Name = "lblPointB";
            this.lblPointB.Size = new System.Drawing.Size(16, 24);
            this.lblPointB.TabIndex = 26;
            this.lblPointB.Text = "-";
            // 
            // lblPointA
            // 
            this.lblPointA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPointA.AutoSize = true;
            this.lblPointA.Location = new System.Drawing.Point(203, 24);
            this.lblPointA.Name = "lblPointA";
            this.lblPointA.Size = new System.Drawing.Size(16, 24);
            this.lblPointA.TabIndex = 25;
            this.lblPointA.Text = "-";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "/";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "/";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "/";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "/";
            // 
            // viewerPage
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "viewerPage";
            this.Text = "Quiz Show";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label checkA;
        private System.Windows.Forms.Label checkB;
        private System.Windows.Forms.Label checkC;
        private System.Windows.Forms.Label checkD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPointA;
        private System.Windows.Forms.Label lblPointD;
        private System.Windows.Forms.Label lblPointC;
        private System.Windows.Forms.Label lblPointB;
    }
}

