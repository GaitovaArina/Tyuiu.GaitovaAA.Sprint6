using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GaitovaAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        Chart chartFunction_GaitovaAA = new Chart();

        public FormMain()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            
            chartFunction_GaitovaAA.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chartFunction_GaitovaAA.ChartAreas.Add(chartArea);

            Series series = new Series("Series1");
            series.ChartArea = "MainArea";
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 2;
            chartFunction_GaitovaAA.Series.Add(series);

            
            panelChart_GaitovaAA.Controls.Add(chartFunction_GaitovaAA);
        }

        DataService ds = new DataService();

        private void buttonDone_GaitovaAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GaitovaAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GaitovaAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                
                this.chartFunction_GaitovaAA.Titles.Clear();
                this.chartFunction_GaitovaAA.Titles.Add("График функции F(x)");
                this.chartFunction_GaitovaAA.ChartAreas["MainArea"].AxisX.Title = "Ось X";
                this.chartFunction_GaitovaAA.ChartAreas["MainArea"].AxisY.Title = "Ось Y";

                
                this.dataGridViewFunction_GaitovaAA.Rows.Clear();
                this.chartFunction_GaitovaAA.Series["Series1"].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_GaitovaAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_GaitovaAA.Series["Series1"].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GaitovaAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПКТб-26-1 Гаитова А.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
