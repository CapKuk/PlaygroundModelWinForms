using PlaygroundModeWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlaygroundModeWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }

        private void Test()
        {
            TestRockingSpringDistributionFunction();
            TestSlideDistributionFunction();
            TestSwingDistributionFunction();
            TestSandboxDistributionFunction();
        }

        private void TestRockingSpringDistributionFunction()
        {
            var name = "Пружина";
            var obj = new RockingSpring();
            chart2.Series[0].IsVisibleInLegend = false;
            chart2.Series.Add(name);
            chart2.Series[name].ChartType = SeriesChartType.Line;
            chart2.Series[name].Color = Color.Red;
            for (double i = 1; i < 17; i += 0.001) chart2.Series[name].Points.AddXY(i, obj.DistributionFunction(i));
        }

        private void TestSlideDistributionFunction()
        {
            var name = "Горка";
            var obj = new Slide();
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series.Add(name);
            chart1.Series[name].ChartType = SeriesChartType.Line;
            chart1.Series[name].Color = Color.Red;
            for (double i = 1; i < 17; i += 0.001) chart1.Series[name].Points.AddXY(i, obj.DistributionFunction(i));
        }

        private void TestSwingDistributionFunction()
        {
            var name = "Качели";
            var obj = new Swing();
            chart4.Series[0].IsVisibleInLegend = false;
            chart4.Series.Add(name);
            chart4.Series[name].ChartType = SeriesChartType.Line;
            chart4.Series[name].Color = Color.Red;
            for (double i = 1; i < 17; i += 0.001) chart4.Series[name].Points.AddXY(i, obj.DistributionFunction(i));
        }

        private void TestSandboxDistributionFunction()
        {
            var name = "Песочница";
            var obj = new SandBox();
            chart5.Series[0].IsVisibleInLegend = false;
            chart5.Series.Add(name);
            chart5.Series[name].ChartType = SeriesChartType.Line;
            chart5.Series[name].Color = Color.Red;
            for (double i = 1; i < 17; i += 0.001) chart5.Series[name].Points.AddXY(i, obj.DistributionFunction(i));
        }
    }
}
