using Tyuiu.GaitovaAA.Sprint6.Task3.V1.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] {
            { 25,  20,  28,   2,   6 },
            { 19,   9,  18,  -7,  24 },
            { 21,  16,   5,  -7,  -8 },
            { 30, -13,   1, -15,   2 },
            { 31,   9,  -3,  -9, -18 }
        };

        private void buttonDone_GaitovaAA_Click(object sender, EventArgs e)
        {
            int[,] resMatrix = ds.Calculate(matrix);

            int rows = resMatrix.GetUpperBound(0) + 1;
            int columns = resMatrix.Length / rows;

            dataGridViewMatrix_GaitovaAA.ColumnCount = columns;
            dataGridViewMatrix_GaitovaAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_GaitovaAA.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_GaitovaAA.Rows[i].Cells[j].Value = Convert.ToString(resMatrix[i, j]);
                }
            }

            textBoxResult_GaitovaAA.Text = "Отсортировано";
        }

        private void buttonHelp_GaitovaAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПКТб-26-1 Гаитова А. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
