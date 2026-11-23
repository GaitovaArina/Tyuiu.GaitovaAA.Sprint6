namespace Tyuiu.GaitovaAA.Sprint6.Task5.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelMain_GAA = new TableLayoutPanel();
            splitContainerTop_GAA = new SplitContainer();
            groupBoxTask_GAA = new GroupBox();
            textBoxTask_GAA = new TextBox();
            buttonHelp_GAA = new Button();
            buttonDone_GAA = new Button();
            buttonOpenFile_GAA = new Button();
            splitContainerBottom_GAA = new SplitContainer();
            groupBoxOutput_GAA = new GroupBox();
            dataGridViewNums_GAA = new DataGridView();
            tableLayoutPanelMain_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTop_GAA).BeginInit();
            splitContainerTop_GAA.Panel1.SuspendLayout();
            splitContainerTop_GAA.Panel2.SuspendLayout();
            splitContainerTop_GAA.SuspendLayout();
            groupBoxTask_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBottom_GAA).BeginInit();
            splitContainerBottom_GAA.Panel1.SuspendLayout();
            splitContainerBottom_GAA.SuspendLayout();
            groupBoxOutput_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_GAA).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain_GAA
            // 
            tableLayoutPanelMain_GAA.ColumnCount = 1;
            tableLayoutPanelMain_GAA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerTop_GAA, 0, 0);
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerBottom_GAA, 0, 1);
            tableLayoutPanelMain_GAA.Dock = DockStyle.Fill;
            tableLayoutPanelMain_GAA.Location = new Point(0, 0);
            tableLayoutPanelMain_GAA.Name = "tableLayoutPanelMain_GAA";
            tableLayoutPanelMain_GAA.RowCount = 2;
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Percent, 17.49503F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Percent, 82.50497F));
            tableLayoutPanelMain_GAA.Size = new Size(963, 500);
            tableLayoutPanelMain_GAA.TabIndex = 0;
            // 
            // splitContainerTop_GAA
            // 
            splitContainerTop_GAA.Dock = DockStyle.Fill;
            splitContainerTop_GAA.Location = new Point(3, 3);
            splitContainerTop_GAA.Name = "splitContainerTop_GAA";
            // 
            // splitContainerTop_GAA.Panel1
            // 
            splitContainerTop_GAA.Panel1.Controls.Add(groupBoxTask_GAA);
            // 
            // splitContainerTop_GAA.Panel2
            // 
            splitContainerTop_GAA.Panel2.Controls.Add(buttonHelp_GAA);
            splitContainerTop_GAA.Panel2.Controls.Add(buttonDone_GAA);
            splitContainerTop_GAA.Panel2.Controls.Add(buttonOpenFile_GAA);
            splitContainerTop_GAA.Size = new Size(957, 81);
            splitContainerTop_GAA.SplitterDistance = 318;
            splitContainerTop_GAA.TabIndex = 0;
            // 
            // groupBoxTask_GAA
            // 
            groupBoxTask_GAA.Controls.Add(textBoxTask_GAA);
            groupBoxTask_GAA.Dock = DockStyle.Fill;
            groupBoxTask_GAA.Location = new Point(0, 0);
            groupBoxTask_GAA.Name = "groupBoxTask_GAA";
            groupBoxTask_GAA.Size = new Size(318, 81);
            groupBoxTask_GAA.TabIndex = 1;
            groupBoxTask_GAA.TabStop = false;
            groupBoxTask_GAA.Text = "Условие";
            // 
            // textBoxTask_GAA
            // 
            textBoxTask_GAA.BorderStyle = BorderStyle.None;
            textBoxTask_GAA.Dock = DockStyle.Fill;
            textBoxTask_GAA.Location = new Point(3, 23);
            textBoxTask_GAA.Multiline = true;
            textBoxTask_GAA.Name = "textBoxTask_GAA";
            textBoxTask_GAA.ReadOnly = true;
            textBoxTask_GAA.Size = new Size(312, 55);
            textBoxTask_GAA.TabIndex = 0;
            textBoxTask_GAA.Text = "Дан список из 20 чисел. Вывести все числа, больше 5.  Построить диаграмму по этим значениям. ";
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.BackColor = Color.CornflowerBlue;
            buttonHelp_GAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAA.Location = new Point(498, 3);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(107, 70);
            buttonHelp_GAA.TabIndex = 2;
            buttonHelp_GAA.Text = "Справка";
            buttonHelp_GAA.UseVisualStyleBackColor = false;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // buttonDone_GAA
            // 
            buttonDone_GAA.BackColor = Color.Green;
            buttonDone_GAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GAA.Location = new Point(191, 3);
            buttonDone_GAA.Name = "buttonDone_GAA";
            buttonDone_GAA.Size = new Size(102, 70);
            buttonDone_GAA.TabIndex = 0;
            buttonDone_GAA.Text = "Выполнить";
            buttonDone_GAA.UseVisualStyleBackColor = false;
            buttonDone_GAA.Click += buttonDone_GAA_Click;
            // 
            // buttonOpenFile_GAA
            // 
            buttonOpenFile_GAA.BackColor = Color.DodgerBlue;
            buttonOpenFile_GAA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_GAA.Location = new Point(339, 3);
            buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            buttonOpenFile_GAA.Size = new Size(108, 70);
            buttonOpenFile_GAA.TabIndex = 1;
            buttonOpenFile_GAA.Text = "Открыть файл";
            buttonOpenFile_GAA.UseVisualStyleBackColor = false;
            buttonOpenFile_GAA.Click += buttonOpenFile_GAA_Click;
            // 
            // splitContainerBottom_GAA
            // 
            splitContainerBottom_GAA.Dock = DockStyle.Fill;
            splitContainerBottom_GAA.FixedPanel = FixedPanel.Panel1;
            splitContainerBottom_GAA.Location = new Point(3, 90);
            splitContainerBottom_GAA.Name = "splitContainerBottom_GAA";
            // 
            // splitContainerBottom_GAA.Panel1
            // 
            splitContainerBottom_GAA.Panel1.Controls.Add(groupBoxOutput_GAA);
            // 
            // splitContainerBottom_GAA.Panel2
            splitContainerBottom_GAA.Size = new Size(957, 407);
            splitContainerBottom_GAA.SplitterDistance = 220;
            splitContainerBottom_GAA.TabIndex = 1;
            // 
            // groupBoxOutput_GAA
            // 
            groupBoxOutput_GAA.Controls.Add(dataGridViewNums_GAA);
            groupBoxOutput_GAA.Dock = DockStyle.Fill;
            groupBoxOutput_GAA.Location = new Point(0, 0);
            groupBoxOutput_GAA.Name = "groupBoxOutput_GAA";
            groupBoxOutput_GAA.Size = new Size(220, 407);
            groupBoxOutput_GAA.TabIndex = 0;
            groupBoxOutput_GAA.TabStop = false;
            groupBoxOutput_GAA.Text = "Вывод данных:";
            // 
            // dataGridViewNums_GAA
            // 
            dataGridViewNums_GAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_GAA.Dock = DockStyle.Fill;
            dataGridViewNums_GAA.Location = new Point(3, 23);
            dataGridViewNums_GAA.Name = "dataGridViewNums_GAA";
            dataGridViewNums_GAA.RowHeadersWidth = 51;
            dataGridViewNums_GAA.Size = new Size(214, 381);
            dataGridViewNums_GAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 500);
            Controls.Add(tableLayoutPanelMain_GAA);
            MinimumSize = new Size(750, 420);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Гаитова А. А.";
            tableLayoutPanelMain_GAA.ResumeLayout(false);
            splitContainerTop_GAA.Panel1.ResumeLayout(false);
            splitContainerTop_GAA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTop_GAA).EndInit();
            splitContainerTop_GAA.ResumeLayout(false);
            groupBoxTask_GAA.ResumeLayout(false);
            groupBoxTask_GAA.PerformLayout();
            splitContainerBottom_GAA.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerBottom_GAA).EndInit();
            splitContainerBottom_GAA.ResumeLayout(false);
            groupBoxOutput_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_GAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain_GAA;
        private SplitContainer splitContainerTop_GAA;
        private Button buttonHelp_GAA;
        private Button buttonOpenFile_GAA;
        private Button buttonDone_GAA;
        private SplitContainer splitContainerBottom_GAA;
        private GroupBox groupBoxOutput_GAA;
        private GroupBox groupBoxTask_GAA;
        private TextBox textBoxTask_GAA;
        private DataGridView dataGridViewNums_GAA;
    }
}
