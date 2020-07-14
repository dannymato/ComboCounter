using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using ComboCounter.Classes;
using MySql.Data.MySqlClient;

namespace ComboCounter.UserControls
{
    public partial class histogram : BaseFormControl
    {

        public histogram()
        {
            InitializeComponent();

        }

        private void histogram_Load(object sender, EventArgs e)
        {

            Color LineColor = ThemeManager.initTextColor();

            chart1.ChartAreas[0].AxisX.LineColor = LineColor;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = LineColor;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = LineColor;
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;

            chart1.ChartAreas[0].AxisY.LineColor = LineColor;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = LineColor;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = LineColor;
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = true;

            chart1.BackColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
        }


        private void UpdateGraph()
        {
            chart1.Series.Clear();
            var chartSeries = new Series
            {
                Name = "Performance Chart",
                Color = ThemeManager.initHeaderColor(),
                IsXValueIndexed = false,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3
            };

            chart1.Series.Add(chartSeries);

            Session session = History.GetSessions()[comboBox1.SelectedIndex];

            for (int i = 0; i < Math.Min(session.Forces.Count, session.Times.Count); i++)
            {
                if (session.Times[i] < 0 || session.Forces[i] < 0)
                {
                    Console.WriteLine("Time: " + session.Times[i] + "\t Force: " + session.Forces[i]);
                }
                chartSeries.Points.AddXY(session.Times[i], session.Forces[i]);
            }

            

            chart1.Invalidate();

            AvgForceInfo.Text = FormatForceValue(session.AvgForce);
            TotForceInfo.Text = FormatForceValue(session.TotalForce);
            HardestHitInfo.Text = FormatForceValue(session.MaxForce);

            averageTimeLabel.Text = FormatTimeValue(session.AverageTime);
            shortestTimeLabel.Text = FormatTimeValue(session.ShortestTime);

        }

        private string FormatForceValue(double force)
        {
            return string.Format("{0:g5} lbs.", force);
        }

        private string FormatTimeValue(double time)
        {
            return string.Format("{0:g5} s", time);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        public override void OnPageAttached()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(History.GetSessions().ToArray());
        }

        private void h44_Click(object sender, EventArgs e)
        {

        }
    }
}
