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
            this.SlideTextBox = new System.Windows.Forms.TextBox();
            this.SwingTextBox = new System.Windows.Forms.TextBox();
            this.SandBoxTextBox = new System.Windows.Forms.TextBox();
            this.RockingSpringTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Size = new System.Drawing.Size(1364, 239);
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
            this.RockingSpringChart.Location = new System.Drawing.Point(1032, 39);
            this.RockingSpringChart.Name = "RockingSpringChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RockingSpringChart.Series.Add(series1);
            this.RockingSpringChart.Size = new System.Drawing.Size(300, 188);
            this.RockingSpringChart.TabIndex = 3;
            this.RockingSpringChart.Text = "chart4";
            // 
            // SandBoxChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SandBoxChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SandBoxChart.Legends.Add(legend2);
            this.SandBoxChart.Location = new System.Drawing.Point(698, 39);
            this.SandBoxChart.Name = "SandBoxChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SandBoxChart.Series.Add(series2);
            this.SandBoxChart.Size = new System.Drawing.Size(300, 188);
            this.SandBoxChart.TabIndex = 2;
            this.SandBoxChart.Text = "chart3";
            // 
            // SwingChart
            // 
            chartArea3.Name = "ChartArea1";
            this.SwingChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.SwingChart.Legends.Add(legend3);
            this.SwingChart.Location = new System.Drawing.Point(337, 39);
            this.SwingChart.Name = "SwingChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.SwingChart.Series.Add(series3);
            this.SwingChart.Size = new System.Drawing.Size(300, 188);
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
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.SlideChart.Series.Add(series4);
            this.SlideChart.Size = new System.Drawing.Size(300, 188);
            this.SlideChart.TabIndex = 0;
            this.SlideChart.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(256, 633);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(911, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phenomena", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(97, 633);
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
            this.label3.Location = new System.Drawing.Point(1183, 633);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "100";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RockingSpringTextBox);
            this.groupBox2.Controls.Add(this.SandBoxTextBox);
            this.groupBox2.Controls.Add(this.SwingTextBox);
            this.groupBox2.Controls.Add(this.SlideTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Phenomena", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(3, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1364, 301);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Полная информация";
            // 
            // SlideTextBox
            // 
            this.SlideTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideTextBox.Location = new System.Drawing.Point(15, 40);
            this.SlideTextBox.Multiline = true;
            this.SlideTextBox.Name = "SlideTextBox";
            this.SlideTextBox.ReadOnly = true;
            this.SlideTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SlideTextBox.Size = new System.Drawing.Size(300, 255);
            this.SlideTextBox.TabIndex = 0;
            // 
            // SwingTextBox
            // 
            this.SwingTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwingTextBox.Location = new System.Drawing.Point(337, 40);
            this.SwingTextBox.Multiline = true;
            this.SwingTextBox.Name = "SwingTextBox";
            this.SwingTextBox.ReadOnly = true;
            this.SwingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SwingTextBox.Size = new System.Drawing.Size(300, 255);
            this.SwingTextBox.TabIndex = 1;
            // 
            // SandBoxTextBox
            // 
            this.SandBoxTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandBoxTextBox.Location = new System.Drawing.Point(698, 40);
            this.SandBoxTextBox.Multiline = true;
            this.SandBoxTextBox.Name = "SandBoxTextBox";
            this.SandBoxTextBox.ReadOnly = true;
            this.SandBoxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SandBoxTextBox.Size = new System.Drawing.Size(300, 255);
            this.SandBoxTextBox.TabIndex = 2;
            // 
            // RockingSpringTextBox
            // 
            this.RockingSpringTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RockingSpringTextBox.Location = new System.Drawing.Point(1023, 40);
            this.RockingSpringTextBox.Multiline = true;
            this.RockingSpringTextBox.Name = "RockingSpringTextBox";
            this.RockingSpringTextBox.ReadOnly = true;
            this.RockingSpringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RockingSpringTextBox.Size = new System.Drawing.Size(300, 255);
            this.RockingSpringTextBox.TabIndex = 3;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1378, 697);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phenomena", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart RockingSpringChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SandBoxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SwingChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RockingSpringTextBox;
        private System.Windows.Forms.TextBox SandBoxTextBox;
        private System.Windows.Forms.TextBox SwingTextBox;
        private System.Windows.Forms.TextBox SlideTextBox;
    }
}