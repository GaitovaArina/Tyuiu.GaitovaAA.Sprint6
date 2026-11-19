namespace Tyuiu.GaitovaAA.Sprint6.Task2.V17
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
            groupBoxCondition_GaitovaAA = new GroupBox();
            groupBox1 = new GroupBox();
            labelCondition_GaitovaAA = new Label();
            groupBoxInput_GaitovaAA = new GroupBox();
            textBoxStop_GaitovaAA = new TextBox();
            labelStop_GaitovaAA = new Label();
            textBoxStart_GaitovaAA = new TextBox();
            labelStart_GaitovaAA = new Label();
            buttonHelp_GaitovaAA = new Button();
            buttonDone_GaitovaAA = new Button();
            groupBoxOutput_GaitovaAA = new GroupBox();
            dataGridViewFunction_GaitovaAA = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFX = new DataGridViewTextBoxColumn();
            labelResult_GaitovaAA = new Label();
            panelChart_GaitovaAA = new Panel();
            groupBoxCondition_GaitovaAA.SuspendLayout();
            groupBoxInput_GaitovaAA.SuspendLayout();
            groupBoxOutput_GaitovaAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GaitovaAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_GaitovaAA
            // 
            groupBoxCondition_GaitovaAA.Controls.Add(groupBox1);
            groupBoxCondition_GaitovaAA.Controls.Add(labelCondition_GaitovaAA);
            groupBoxCondition_GaitovaAA.Location = new Point(12, 12);
            groupBoxCondition_GaitovaAA.Name = "groupBoxCondition_GaitovaAA";
            groupBoxCondition_GaitovaAA.Size = new Size(640, 317);
            groupBoxCondition_GaitovaAA.TabIndex = 0;
            groupBoxCondition_GaitovaAA.TabStop = false;
            groupBoxCondition_GaitovaAA.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelCondition_GaitovaAA
            // 
            labelCondition_GaitovaAA.Location = new Point(6, 23);
            labelCondition_GaitovaAA.Name = "labelCondition_GaitovaAA";
            labelCondition_GaitovaAA.Size = new Size(628, 52);
            labelCondition_GaitovaAA.TabIndex = 0;
            labelCondition_GaitovaAA.Text = "Протабулировать функцию F(x) = cos(x) + 4x/2 - sin(x)*3x на заданном диапазоне [-5; 5] с шагом 1. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_GaitovaAA
            // 
            groupBoxInput_GaitovaAA.Controls.Add(textBoxStop_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(labelStop_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(textBoxStart_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(labelStart_GaitovaAA);
            groupBoxInput_GaitovaAA.Location = new Point(12, 335);
            groupBoxInput_GaitovaAA.Name = "groupBoxInput_GaitovaAA";
            groupBoxInput_GaitovaAA.Size = new Size(277, 111);
            groupBoxInput_GaitovaAA.TabIndex = 1;
            groupBoxInput_GaitovaAA.TabStop = false;
            groupBoxInput_GaitovaAA.Text = "Ввод данных";
            // 
            // textBoxStop_GaitovaAA
            // 
            textBoxStop_GaitovaAA.Location = new Point(140, 51);
            textBoxStop_GaitovaAA.Multiline = true;
            textBoxStop_GaitovaAA.Name = "textBoxStop_GaitovaAA";
            textBoxStop_GaitovaAA.Size = new Size(94, 47);
            textBoxStop_GaitovaAA.TabIndex = 2;
            textBoxStop_GaitovaAA.Text = "5";
            // 
            // labelStop_GaitovaAA
            // 
            labelStop_GaitovaAA.AutoSize = true;
            labelStop_GaitovaAA.Location = new Point(140, 23);
            labelStop_GaitovaAA.Name = "labelStop_GaitovaAA";
            labelStop_GaitovaAA.Size = new Size(94, 20);
            labelStop_GaitovaAA.TabIndex = 2;
            labelStop_GaitovaAA.Text = "Конец шага:";
            // 
            // textBoxStart_GaitovaAA
            // 
            textBoxStart_GaitovaAA.Location = new Point(12, 51);
            textBoxStart_GaitovaAA.Multiline = true;
            textBoxStart_GaitovaAA.Name = "textBoxStart_GaitovaAA";
            textBoxStart_GaitovaAA.Size = new Size(82, 47);
            textBoxStart_GaitovaAA.TabIndex = 2;
            textBoxStart_GaitovaAA.Text = "-5";
            // 
            // labelStart_GaitovaAA
            // 
            labelStart_GaitovaAA.AutoSize = true;
            labelStart_GaitovaAA.Location = new Point(6, 23);
            labelStart_GaitovaAA.Name = "labelStart_GaitovaAA";
            labelStart_GaitovaAA.Size = new Size(88, 20);
            labelStart_GaitovaAA.TabIndex = 2;
            labelStart_GaitovaAA.Text = "Старт шага:";
            // 
            // buttonHelp_GaitovaAA
            // 
            buttonHelp_GaitovaAA.BackColor = Color.DodgerBlue;
            buttonHelp_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GaitovaAA.Location = new Point(309, 346);
            buttonHelp_GaitovaAA.Name = "buttonHelp_GaitovaAA";
            buttonHelp_GaitovaAA.Size = new Size(101, 100);
            buttonHelp_GaitovaAA.TabIndex = 2;
            buttonHelp_GaitovaAA.Text = "Справка";
            buttonHelp_GaitovaAA.UseVisualStyleBackColor = false;
            buttonHelp_GaitovaAA.Click += this.buttonHelp_GaitovaAA_Click;
            // 
            // buttonDone_GaitovaAA
            // 
            buttonDone_GaitovaAA.BackColor = Color.ForestGreen;
            buttonDone_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GaitovaAA.Location = new Point(426, 346);
            buttonDone_GaitovaAA.Name = "buttonDone_GaitovaAA";
            buttonDone_GaitovaAA.Size = new Size(226, 100);
            buttonDone_GaitovaAA.TabIndex = 3;
            buttonDone_GaitovaAA.Text = "Выполнить";
            buttonDone_GaitovaAA.UseVisualStyleBackColor = false;
            buttonDone_GaitovaAA.Click += this.buttonDone_GaitovaAA_Click;
            // 
            // groupBoxOutput_GaitovaAA
            // 
            groupBoxOutput_GaitovaAA.Controls.Add(panelChart_GaitovaAA);
            groupBoxOutput_GaitovaAA.Controls.Add(dataGridViewFunction_GaitovaAA);
            groupBoxOutput_GaitovaAA.Controls.Add(labelResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Location = new Point(669, 12);
            groupBoxOutput_GaitovaAA.Name = "groupBoxOutput_GaitovaAA";
            groupBoxOutput_GaitovaAA.Size = new Size(686, 434);
            groupBoxOutput_GaitovaAA.TabIndex = 4;
            groupBoxOutput_GaitovaAA.TabStop = false;
            groupBoxOutput_GaitovaAA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_GaitovaAA
            // 
            dataGridViewFunction_GaitovaAA.AllowUserToAddRows = false;
            dataGridViewFunction_GaitovaAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_GaitovaAA.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFX });
            dataGridViewFunction_GaitovaAA.Location = new Point(6, 58);
            dataGridViewFunction_GaitovaAA.Name = "dataGridViewFunction_GaitovaAA";
            dataGridViewFunction_GaitovaAA.RowHeadersVisible = false;
            dataGridViewFunction_GaitovaAA.RowHeadersWidth = 51;
            dataGridViewFunction_GaitovaAA.Size = new Size(257, 363);
            dataGridViewFunction_GaitovaAA.TabIndex = 1;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 125;
            // 
            // ColumnFX
            // 
            ColumnFX.HeaderText = "FX";
            ColumnFX.MinimumWidth = 6;
            ColumnFX.Name = "ColumnFX";
            ColumnFX.Width = 125;
            // 
            // labelResult_GaitovaAA
            // 
            labelResult_GaitovaAA.AutoSize = true;
            labelResult_GaitovaAA.Location = new Point(6, 23);
            labelResult_GaitovaAA.Name = "labelResult_GaitovaAA";
            labelResult_GaitovaAA.Size = new Size(78, 20);
            labelResult_GaitovaAA.TabIndex = 0;
            labelResult_GaitovaAA.Text = "Результат:";
            // 
            // panelChart_GaitovaAA
            // 
            panelChart_GaitovaAA.Location = new Point(285, 58);
            panelChart_GaitovaAA.Name = "panelChart_GaitovaAA";
            panelChart_GaitovaAA.Size = new Size(395, 363);
            panelChart_GaitovaAA.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 461);
            Controls.Add(groupBoxOutput_GaitovaAA);
            Controls.Add(buttonDone_GaitovaAA);
            Controls.Add(buttonHelp_GaitovaAA);
            Controls.Add(groupBoxInput_GaitovaAA);
            Controls.Add(groupBoxCondition_GaitovaAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Гаитова А. А.";
            groupBoxCondition_GaitovaAA.ResumeLayout(false);
            groupBoxInput_GaitovaAA.ResumeLayout(false);
            groupBoxInput_GaitovaAA.PerformLayout();
            groupBoxOutput_GaitovaAA.ResumeLayout(false);
            groupBoxOutput_GaitovaAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GaitovaAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GaitovaAA;
        private GroupBox groupBox1;
        private Label labelCondition_GaitovaAA;
        private GroupBox groupBoxInput_GaitovaAA;
        private TextBox textBoxStop_GaitovaAA;
        private Label labelStop_GaitovaAA;
        private TextBox textBoxStart_GaitovaAA;
        private Label labelStart_GaitovaAA;
        private Button buttonHelp_GaitovaAA;
        private Button buttonDone_GaitovaAA;
        private GroupBox groupBoxOutput_GaitovaAA;
        private DataGridView dataGridViewFunction_GaitovaAA;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFX;
        private Label labelResult_GaitovaAA;
        private Panel panelChart_GaitovaAA;
    }
}
