using Tyuiu.GaitovaAA.Sprint6.Task0.V12.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_GaitovaAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_GaitovaAA.Text);
                double res = ds.Calculate(x);
                textBoxResult_GaitovaAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_GaitovaAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_GaitovaAA_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Таск 0 выполнила Гаитова А.А. группы ПКТб-26-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
