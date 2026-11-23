using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GaitovaAA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        private Chart chartDiag_GAA;

        string path = @"C:\DataSprint6\InPutDataFileTask5V22.txt";


        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chartDiag_GAA = new Chart();
            chartDiag_GAA.Name = "chartDiag_GAA";
            chartDiag_GAA.Dock = DockStyle.Fill;

            chartDiag_GAA.ChartAreas.Add(new ChartArea("Default"));
            chartDiag_GAA.Series.Add(new Series("Series1"));

            splitContainerBottom_GAA.Panel2.Controls.Add(chartDiag_GAA);
        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNums_GAA.ColumnCount = 2;
                dataGridViewNums_GAA.Columns[0].Width = 45;
                dataGridViewNums_GAA.Columns[1].Width = 110;
                dataGridViewNums_GAA.Rows.Clear();

                chartDiag_GAA.ChartAreas[0].AxisX.Title = "Ось X";
                chartDiag_GAA.ChartAreas[0].AxisY.Title = "Ось Y";
                chartDiag_GAA.Series[0].Points.Clear();
                chartDiag_GAA.Series[0].ChartType = SeriesChartType.Column;
                chartDiag_GAA.Series[0].Color = Color.Green;

                double[] numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewNums_GAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartDiag_GAA.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении файла! Проверьте наличие файла по пути:\n" + path, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл в блокноте", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнила студентка группы ПКТб-26-1 Гаитова А. А.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
