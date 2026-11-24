using System.IO;
using Tyuiu.GaitovaAA.Sprint6.Task6.V30.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath = "";
        DataService ds = new DataService();

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            textBoxOut_GAA.Text = ds.CollectTextFromFile(openFilePath);
        }
       

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GAA.ShowDialog();
            openFilePath = openFileDialogTask_GAA.FileName;
            textBoxIn_GAA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_GAA.Text = groupBoxIn_GAA.Text + " " + openFileDialogTask_GAA.FileName;
            buttonDone_GAA.Enabled = true;
        }

        private void buttonOpenFile_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_GAA.ToolTipTitle = "Открыть файл";
            toolTipTask_GAA.SetToolTip(buttonOpenFile_GAA, "Выберите нужный файл для обработки");
        }

        private void buttonDone_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_GAA.ToolTipTitle = "Выполнить";
            toolTipTask_GAA.SetToolTip(buttonDone_GAA, "Вывести четвертое слово каждой строки файла");
        }

        private void buttonHelp_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_GAA.ToolTipTitle = "Справка";
            toolTipTask_GAA.SetToolTip(buttonHelp_GAA, "Информация об авторе программы");
        }
    }
}
