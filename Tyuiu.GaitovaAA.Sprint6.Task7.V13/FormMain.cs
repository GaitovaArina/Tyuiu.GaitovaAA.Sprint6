using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.GaitovaAA.Sprint6.Task7.V13.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            if (buttonOpenFile_GAA.Image != null)
                buttonOpenFile_GAA.Image = new System.Drawing.Bitmap(buttonOpenFile_GAA.Image, new System.Drawing.Size(40, 40));

            if (buttonDone_GAA.Image != null)
                buttonDone_GAA.Image = new System.Drawing.Bitmap(buttonDone_GAA.Image, new System.Drawing.Size(40, 40));

            if (buttonSaveFile_GAA.Image != null)
                buttonSaveFile_GAA.Image = new System.Drawing.Bitmap(buttonSaveFile_GAA.Image, new System.Drawing.Size(40, 40));

            if (buttonHelp_GAA.Image != null)
                buttonHelp_GAA.Image = new System.Drawing.Bitmap(buttonHelp_GAA.Image, new System.Drawing.Size(40, 40));

            toolTipButton_GAA.IsBalloon = true;
            toolTipButton_GAA.ToolTipIcon = ToolTipIcon.Info;

            buttonDone_GAA.Enabled = false;
            buttonSaveFile_GAA.Enabled = false;

            dataGridViewIn_GAA.ColumnCount = 50;
            dataGridViewIn_GAA.RowCount = 50;
            dataGridViewOut_GAA.ColumnCount = 50;
            dataGridViewOut_GAA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_GAA.Columns[i].Width = 25;
                dataGridViewOut_GAA.Columns[i].Width = 25;
            }
        }


        static int rows;
        static int cols;
        static string openFilePath = "";

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath)
                                 .Where(line => !string.IsNullOrWhiteSpace(line))
                                 .ToArray();

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c].Trim());
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_GAA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_GAA.FileName;

                int[,] arrayValues = LoadFromFileData(openFilePath);

                dataGridViewIn_GAA.ColumnCount = cols;
                dataGridViewIn_GAA.RowCount = rows;
                dataGridViewOut_GAA.ColumnCount = cols;
                dataGridViewOut_GAA.RowCount = rows;

                for (int i = 0; i < cols; i++)
                {
                    dataGridViewIn_GAA.Columns[i].Width = 35;
                    dataGridViewOut_GAA.Columns[i].Width = 35;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dataGridViewIn_GAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                groupBoxIn_GAA.Text = "Ввод: " + openFilePath;

                buttonDone_GAA.Enabled = true;
                buttonSaveFile_GAA.Enabled = true;
            }
        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_GAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonSaveFile_GAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_GAA.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogMatrix_GAA.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogMatrix_GAA.FileName;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                int rowCount = dataGridViewOut_GAA.RowCount;
                int columnCount = dataGridViewOut_GAA.ColumnCount;
                string str = "";

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (j != columnCount - 1)
                        {
                            str = str + dataGridViewOut_GAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_GAA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                    str = "";
                }
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GAA.ToolTipTitle = "Открыть файл";
            toolTipButton_GAA.SetToolTip(buttonOpenFile_GAA, "Открыть файл для обработки данных в формате CSV");
        }

        private void buttonDone_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GAA.ToolTipTitle = "Выполнить";
            toolTipButton_GAA.SetToolTip(buttonDone_GAA, "Выполнить обработку данных");
        }

        private void buttonSaveFile_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GAA.ToolTipTitle = "Сохранить в файл";
            toolTipButton_GAA.SetToolTip(buttonSaveFile_GAA, "Сохранить обработанные данные в файл в формате CSV");
        }

        private void buttonHelp_GAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GAA.ToolTipTitle = "Справка";
            toolTipButton_GAA.SetToolTip(buttonHelp_GAA, "Сведение о программе");
        }
    }
}
