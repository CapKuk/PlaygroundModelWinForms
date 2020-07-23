using PlaygroundModeWinForms.Models;
using PlaygroundModeWinForms.Presenters;
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

namespace PlaygroundModeWinForms.Views
{
    public partial class ModelForm : Form
    {
        public static event Action<int> MoveButtonDown;
        public static event Action StartSimulator;

        public ModelForm()
        {
            InitializeComponent();

            ModelPresenter.DataChanged += ChangeModelView;
            ModelPresenter.CountChanged += ChangeCount;
            StartSimulator();
        }

        private void ChangeCount(int count)
        {
            label3.Text = (count - 1).ToString();
            trackBar1.Maximum = count - 1;
            trackBar1.Value = count - 1;
        }

        private void ClearCharts()
        {
            
            SandBoxChart.Series["Песочница"].Points.Clear();
            SlideChart.Series["Горка"].Points.Clear();
            SwingChart.Series["Качеля"].Points.Clear();
            RockingSpringChart.Series["Качалка на пружине"].Points.Clear();
        }

        private void ClearTextBoxes()
        {
            SandBoxTextBox.Text = "";
            SlideTextBox.Text = "";
            SwingTextBox.Text = "";
            RockingSpringTextBox.Text = "";
        }

        private void ChangeModelView((List<Dictionary<Elements, double>>, Dictionary<Elements, History>) ElementsList)
        {
            ClearCharts();
            ClearTextBoxes();

            foreach (var Element in ElementsList.Item1)
            {
                SandBoxChart.Series["Песочница"].Points.AddXY(Element[Elements.Time], Element[Elements.SandBox]);
                SlideChart.Series["Горка"].Points.AddXY(Element[Elements.Time], Element[Elements.Slide]);
                SwingChart.Series["Качеля"].Points.AddXY(Element[Elements.Time], Element[Elements.Swing]);
                RockingSpringChart.Series["Качалка на пружине"].Points.AddXY(Element[Elements.Time], Element[Elements.RockingSpring]);
            }

            foreach (var i in ElementsList.Item2[Elements.SandBox].HistoryList) SandBoxTextBox.Text += i;
            foreach (var i in ElementsList.Item2[Elements.Slide].HistoryList) SlideTextBox.Text += i;
            foreach (var i in ElementsList.Item2[Elements.Swing].HistoryList) SwingTextBox.Text += i;
            foreach (var i in ElementsList.Item2[Elements.RockingSpring].HistoryList) RockingSpringTextBox.Text += i;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void Movebutton_Click(object sender, EventArgs e)
        {
            MoveButtonDown(trackBar1.Value);
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            ClearCharts();
        }
    }
}
