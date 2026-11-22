using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GaitovaAA.Sprint6.Task4.V1.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task4.V1
{
    public partial class FormMain : Form
    {
        private Chart chartFunction_GAA;

        public FormMain()
        {
            InitializeComponent();
            InitializeChart(); 
        }

        private void InitializeChart()
        {
            chartFunction_GAA = new Chart();
            chartFunction_GAA.Name = "chartFunction_GAA";
            chartFunction_GAA.Dock = DockStyle.Fill;

            chartFunction_GAA.ChartAreas.Add(new ChartArea("Default"));
            chartFunction_GAA.Series.Add(new Series("Series1"));
            chartFunction_GAA.Titles.Add("График функции F(x)");

            splitContainerBottom_GAA.Panel2.Controls.Add(chartFunction_GAA);
        }

        DataService ds = new DataService();

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GAA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;

                chartFunction_GAA.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_GAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_GAA.Text = "";
                chartFunction_GAA.Series[0].Points.Clear();
                chartFunction_GAA.Series[0].ChartType = SeriesChartType.Spline;
                chartFunction_GAA.Series[0].BorderWidth = 2;

                for (int i = 0; i < len; i++)
                {
                    chartFunction_GAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_GAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V1.txt");
                File.WriteAllText(path, textBoxResult_GAA.Text);

                DialogResult dialogResult = MessageBox.Show(
                    "Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 4 выполнила студентка группы ПКТб-26-1 Гаитова А. А.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
