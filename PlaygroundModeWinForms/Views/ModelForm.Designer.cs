namespace PlaygroundModeWinForms.Views
{
    partial class ModelForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RockingSpringChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SandBoxChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SwingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SlideChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RockingSpringTextBox = new System.Windows.Forms.TextBox();
            this.SandBoxTextBox = new System.Windows.Forms.TextBox();
            this.SwingTextBox = new System.Windows.Forms.TextBox();
            this.SlideTextBox = new System.Windows.Forms.TextBox();
            this.Movebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RockingSpringChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandBoxChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.RockingSpringChart);
            this.groupBox1.Controls.Add(this.SandBoxChart);
            this.groupBox1.Controls.Add(this.SwingChart);
            this.groupBox1.Controls.Add(this.SlideChart);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Phenomena", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1611, 561);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Посещения элементов";
            // 
            // RockingSpringChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RockingSpringChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RockingSpringChart.Legends.Add(legend1);
            this.RockingSpringChart.Location = new System.Drawing.Point(821, 310);
            this.RockingSpringChart.Name = "RockingSpringChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Качалка на пружине";
            this.RockingSpringChart.Series.Add(series1);
            this.RockingSpringChart.Size = new System.Drawing.Size(708, 247);
            this.RockingSpringChart.TabIndex = 3;
            this.RockingSpringChart.Text = "chart3";
            // 
            // SandBoxChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SandBoxChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SandBoxChart.Legends.Add(legend2);
            this.SandBoxChart.Location = new System.Drawing.Point(821, 39);
            this.SandBoxChart.Name = "SandBoxChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Песочница";
            this.SandBoxChart.Series.Add(series2);
            this.SandBoxChart.Size = new System.Drawing.Size(708, 247);
            this.SandBoxChart.TabIndex = 2;
            this.SandBoxChart.Text = "chart3";
            // 
            // SwingChart
            // 
            chartArea3.Name = "ChartArea1";
            this.SwingChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.SwingChart.Legends.Add(legend3);
            this.SwingChart.Location = new System.Drawing.Point(5, 310);
            this.SwingChart.Name = "SwingChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Качеля";
            this.SwingChart.Series.Add(series3);
            this.SwingChart.Size = new System.Drawing.Size(798, 245);
            this.SwingChart.TabIndex = 1;
            this.SwingChart.Text = "chart2";
            // 
            // SlideChart
            // 
            chartArea4.Name = "ChartArea1";
            this.SlideChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.SlideChart.Legends.Add(legend4);
            this.SlideChart.Location = new System.Drawing.Point(15, 39);
            this.SlideChart.Name = "SlideChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Горка";
            this.SlideChart.Series.Add(series4);
            this.SlideChart.Size = new System.Drawing.Size(788, 247);
            this.SlideChart.TabIndex = 0;
            this.SlideChart.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(201, 898);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar1.Maximum = 85;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1014, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 85;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phenomena", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 898);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Временная шкала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phenomena Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(1236, 898);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "85";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RockingSpringTextBox);
            this.groupBox2.Controls.Add(this.SandBoxTextBox);
            this.groupBox2.Controls.Add(this.SwingTextBox);
            this.groupBox2.Controls.Add(this.SlideTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Phenomena", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(-6, 562);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1647, 301);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Полная информация";
            // 
            // RockingSpringTextBox
            // 
            this.RockingSpringTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RockingSpringTextBox.Location = new System.Drawing.Point(1229, 39);
            this.RockingSpringTextBox.Multiline = true;
            this.RockingSpringTextBox.Name = "RockingSpringTextBox";
            this.RockingSpringTextBox.ReadOnly = true;
            this.RockingSpringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RockingSpringTextBox.Size = new System.Drawing.Size(412, 255);
            this.RockingSpringTextBox.TabIndex = 3;
            // 
            // SandBoxTextBox
            // 
            this.SandBoxTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SandBoxTextBox.Location = new System.Drawing.Point(800, 39);
            this.SandBoxTextBox.Multiline = true;
            this.SandBoxTextBox.Name = "SandBoxTextBox";
            this.SandBoxTextBox.ReadOnly = true;
            this.SandBoxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SandBoxTextBox.Size = new System.Drawing.Size(423, 255);
            this.SandBoxTextBox.TabIndex = 2;
            // 
            // SwingTextBox
            // 
            this.SwingTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwingTextBox.Location = new System.Drawing.Point(399, 39);
            this.SwingTextBox.Multiline = true;
            this.SwingTextBox.Name = "SwingTextBox";
            this.SwingTextBox.ReadOnly = true;
            this.SwingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SwingTextBox.Size = new System.Drawing.Size(395, 255);
            this.SwingTextBox.TabIndex = 1;
            // 
            // SlideTextBox
            // 
            this.SlideTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlideTextBox.Location = new System.Drawing.Point(15, 39);
            this.SlideTextBox.Multiline = true;
            this.SlideTextBox.Name = "SlideTextBox";
            this.SlideTextBox.ReadOnly = true;
            this.SlideTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SlideTextBox.Size = new System.Drawing.Size(378, 255);
            this.SlideTextBox.TabIndex = 0;
            // 
            // Movebutton
            // 
            this.Movebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Movebutton.FlatAppearance.BorderSize = 0;
            this.Movebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movebutton.Font = new System.Drawing.Font("Phenomena", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Movebutton.Location = new System.Drawing.Point(1300, 880);
            this.Movebutton.Name = "Movebutton";
            this.Movebutton.Size = new System.Drawing.Size(281, 59);
            this.Movebutton.TabIndex = 6;
            this.Movebutton.Text = "Переместиться";
            this.Movebutton.UseVisualStyleBackColor = false;
            this.Movebutton.Click += new System.EventHandler(this.Movebutton_Click);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1639, 951);
            this.Controls.Add(this.Movebutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phenomena", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RockingSpringChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandBoxChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart SlideChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart SandBoxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SwingChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RockingSpringTextBox;
        private System.Windows.Forms.TextBox SandBoxTextBox;
        private System.Windows.Forms.TextBox SwingTextBox;
        private System.Windows.Forms.TextBox SlideTextBox;
        private System.Windows.Forms.Button Movebutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart RockingSpringChart;
    }
}