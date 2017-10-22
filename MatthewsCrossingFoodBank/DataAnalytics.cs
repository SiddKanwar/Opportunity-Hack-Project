using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MatthewsCrossingFoodBank
{
    public partial class DataAnalytics : Form
    {
        private List<Donor> donors;

        public DataAnalytics()
        {
            InitializeComponent();
        }

        public DataAnalytics(List<Donor> donors)
        {
            this.donors = donors;

            InitializeComponent();


            // Get counts of Food/Monetary
            int food = 0;
            int money = 0;
            for (int i = 1; i < donors.Count; i++)
            {
                if (donors[i].donationType != "")
                {
                    if (donors[i].donationType == "Food")
                        food++;
                    else
                        money++;
                }
            }

            Console.WriteLine("Food: " + food + "   Money: " + money);

            pieChart.Series.Clear();
            pieChart.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            pieChart.Legends.Add("MyLegend");
            pieChart.Legends[0].LegendStyle = LegendStyle.Table;
            pieChart.Legends[0].Docking = Docking.Bottom;
            pieChart.Legends[0].Alignment = StringAlignment.Center;
            pieChart.Legends[0].Title = "Donation Types";
            pieChart.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "Donation Types";
            pieChart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            pieChart.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            pieChart.Series[seriesname].Points.AddXY("Food Donation", food);
            pieChart.Series[seriesname].Points.AddXY("Monetary Donation", money);




            int[] yData = new int[7];

            // Count days of week
            for (int i = 0; i < donors.Count; i++)
            {
                try
                {
                    string[] date = donors[i].donatedOn.Split('/');
                    int month = Convert.ToInt32(date[0]);
                    int day = Convert.ToInt32(date[1]);
                    int year = Convert.ToInt32(date[2]);

                    DateTime dateValue = new DateTime(year, month, day);
                    yData[(int)dateValue.DayOfWeek]++;
                } catch (Exception ex)
                {

                }
            }

            int sum = 0;
            for (int i = 0; i < yData.Length; i++)
            {
                sum += yData[i];
            }
            int maxValue = 0;
            for (int i = 0; i < yData.Length; i++)
            {
                if (yData[i] > maxValue) maxValue = yData[i];
            }

            barChart.ChartAreas[0].AxisX.Maximum = 6;
            barChart.ChartAreas[0].AxisX.Minimum = 0;
            barChart.ChartAreas[0].AxisY.Maximum = maxValue;
            barChart.ChartAreas[0].AxisY.Minimum = 0;


            ChartArea area2 = new ChartArea("Second");
            barChart.ChartAreas.Add(area2);
            Series barSeries2 = new Series();
            barSeries2.Points.DataBindY(yData);
            barSeries2.ChartType = SeriesChartType.Column;
            barSeries2.ChartArea = "Second";
            barChart.Series.Add(barSeries2);
        }

        private void DataAnalytics_Load(object sender, EventArgs e)
        {
           
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
