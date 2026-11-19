using Tyuiu.GaitovaAA.Sprint6.Task1.V11.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task1.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_GaitovaAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GaitovaAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GaitovaAA.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_GaitovaAA.Text = "";
                textBoxResult_GaitovaAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_GaitovaAA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_GaitovaAA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_GaitovaAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_GaitovaAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GaitovaAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-26-1 Гаитова А.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
