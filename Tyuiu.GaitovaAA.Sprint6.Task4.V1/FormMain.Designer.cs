namespace Tyuiu.GaitovaAA.Sprint6.Task4.V1
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
            splitContainerBottom_GAA = new SplitContainer();
            groupBoxTask_GAA = new GroupBox();
            textBoxTask_GAA = new TextBox();
            groupBoxInput_GAA = new GroupBox();
            labelStartStep_GAA = new Label();
            textBoxStartStep_GAA = new TextBox();
            labelStopStep_GAA = new Label();
            textBoxStopStep_GAA = new TextBox();
            buttonDone_GAA = new Button();
            buttonSave_GAA = new Button();
            buttonHelp_GAA = new Button();
            groupBoxOutput_GAA = new GroupBox();
            textBoxResult_GAA = new TextBox();
            tableLayoutPanelMain_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTop_GAA).BeginInit();
            splitContainerTop_GAA.Panel1.SuspendLayout();
            splitContainerTop_GAA.Panel2.SuspendLayout();
            splitContainerTop_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBottom_GAA).BeginInit();
            splitContainerBottom_GAA.Panel1.SuspendLayout();
            splitContainerBottom_GAA.SuspendLayout();
            groupBoxTask_GAA.SuspendLayout();
            groupBoxInput_GAA.SuspendLayout();
            groupBoxOutput_GAA.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain_GAA
            // 
            tableLayoutPanelMain_GAA.ColumnCount = 1;
            tableLayoutPanelMain_GAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8505039F));
            tableLayoutPanelMain_GAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.1495F));
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerTop_GAA, 0, 0);
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerBottom_GAA, 0, 1);
            tableLayoutPanelMain_GAA.Dock = DockStyle.Fill;
            tableLayoutPanelMain_GAA.Location = new Point(0, 0);
            tableLayoutPanelMain_GAA.Name = "tableLayoutPanelMain_GAA";
            tableLayoutPanelMain_GAA.RowCount = 2;
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9600735F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Percent, 78.0399246F));
            tableLayoutPanelMain_GAA.Size = new Size(1032, 553);
            tableLayoutPanelMain_GAA.TabIndex = 0;
            // 
            // splitContainerTop_GAA
            // 
            splitContainerTop_GAA.Dock = DockStyle.Fill;
            splitContainerTop_GAA.IsSplitterFixed = true;
            splitContainerTop_GAA.Location = new Point(3, 3);
            splitContainerTop_GAA.Name = "splitContainerTop_GAA";
            // 
            // splitContainerTop_GAA.Panel1
            // 
            splitContainerTop_GAA.Panel1.Controls.Add(groupBoxTask_GAA);
            // 
            // splitContainerTop_GAA.Panel2
            // 
            splitContainerTop_GAA.Panel2.Controls.Add(groupBoxInput_GAA);
            splitContainerTop_GAA.Size = new Size(1026, 115);
            splitContainerTop_GAA.SplitterDistance = 342;
            splitContainerTop_GAA.TabIndex = 0;
            // 
            // splitContainerBottom_GAA
            // 
            splitContainerBottom_GAA.Dock = DockStyle.Fill;
            splitContainerBottom_GAA.FixedPanel = FixedPanel.Panel1;
            splitContainerBottom_GAA.IsSplitterFixed = true;
            splitContainerBottom_GAA.Location = new Point(3, 124);
            splitContainerBottom_GAA.Name = "splitContainerBottom_GAA";
            // 
            // splitContainerBottom_GAA.Panel1
            // 
            splitContainerBottom_GAA.Panel1.Controls.Add(groupBoxOutput_GAA);
            splitContainerBottom_GAA.Size = new Size(1026, 426);
            splitContainerBottom_GAA.SplitterDistance = 230;
            splitContainerBottom_GAA.TabIndex = 1;
            // 
            // groupBoxTask_GAA
            // 
            groupBoxTask_GAA.Controls.Add(textBoxTask_GAA);
            groupBoxTask_GAA.Dock = DockStyle.Fill;
            groupBoxTask_GAA.Location = new Point(0, 0);
            groupBoxTask_GAA.Name = "groupBoxTask_GAA";
            groupBoxTask_GAA.Size = new Size(342, 115);
            groupBoxTask_GAA.TabIndex = 0;
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
            textBoxTask_GAA.Size = new Size(336, 89);
            textBoxTask_GAA.TabIndex = 0;
            textBoxTask_GAA.Text = "Написать программу, которая выводит таблицу значений функции: F(x) = sin(x)/(x+1,2) + cos(x)7x - 2 на заданном диапазоне [-5; 5] с шагом 1.";
            // 
            // groupBoxInput_GAA
            // 
            groupBoxInput_GAA.Controls.Add(buttonHelp_GAA);
            groupBoxInput_GAA.Controls.Add(buttonSave_GAA);
            groupBoxInput_GAA.Controls.Add(buttonDone_GAA);
            groupBoxInput_GAA.Controls.Add(textBoxStopStep_GAA);
            groupBoxInput_GAA.Controls.Add(labelStopStep_GAA);
            groupBoxInput_GAA.Controls.Add(textBoxStartStep_GAA);
            groupBoxInput_GAA.Controls.Add(labelStartStep_GAA);
            groupBoxInput_GAA.Dock = DockStyle.Fill;
            groupBoxInput_GAA.Location = new Point(0, 0);
            groupBoxInput_GAA.Name = "groupBoxInput_GAA";
            groupBoxInput_GAA.Size = new Size(680, 115);
            groupBoxInput_GAA.TabIndex = 0;
            groupBoxInput_GAA.TabStop = false;
            groupBoxInput_GAA.Text = "Ввод данных";
            // 
            // labelStartStep_GAA
            // 
            labelStartStep_GAA.AutoSize = true;
            labelStartStep_GAA.Location = new Point(6, 23);
            labelStartStep_GAA.Name = "labelStartStep_GAA";
            labelStartStep_GAA.Size = new Size(88, 20);
            labelStartStep_GAA.TabIndex = 0;
            labelStartStep_GAA.Text = "Старт шага:";
            // 
            // textBoxStartStep_GAA
            // 
            textBoxStartStep_GAA.Location = new Point(6, 46);
            textBoxStartStep_GAA.Name = "textBoxStartStep_GAA";
            textBoxStartStep_GAA.Size = new Size(70, 27);
            textBoxStartStep_GAA.TabIndex = 1;
            textBoxStartStep_GAA.Text = "-5";
            // 
            // labelStopStep_GAA
            // 
            labelStopStep_GAA.AutoSize = true;
            labelStopStep_GAA.Location = new Point(112, 23);
            labelStopStep_GAA.Name = "labelStopStep_GAA";
            labelStopStep_GAA.Size = new Size(94, 20);
            labelStopStep_GAA.TabIndex = 2;
            labelStopStep_GAA.Text = "Конец шага:";
            // 
            // textBoxStopStep_GAA
            // 
            textBoxStopStep_GAA.Location = new Point(112, 46);
            textBoxStopStep_GAA.Name = "textBoxStopStep_GAA";
            textBoxStopStep_GAA.Size = new Size(70, 27);
            textBoxStopStep_GAA.TabIndex = 3;
            textBoxStopStep_GAA.Text = "5";
            // 
            // buttonDone_GAA
            // 
            buttonDone_GAA.BackColor = Color.Green;
            buttonDone_GAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GAA.ForeColor = Color.Black;
            buttonDone_GAA.Location = new Point(251, 16);
            buttonDone_GAA.Name = "buttonDone_GAA";
            buttonDone_GAA.Size = new Size(102, 86);
            buttonDone_GAA.TabIndex = 4;
            buttonDone_GAA.Text = "Выполнить";
            buttonDone_GAA.UseVisualStyleBackColor = false;
            buttonDone_GAA.Click += this.buttonDone_GAA_Click;
            // 
            // buttonSave_GAA
            // 
            buttonSave_GAA.BackColor = Color.DodgerBlue;
            buttonSave_GAA.FlatStyle = FlatStyle.Flat;
            buttonSave_GAA.Location = new Point(370, 16);
            buttonSave_GAA.Name = "buttonSave_GAA";
            buttonSave_GAA.Size = new Size(94, 86);
            buttonSave_GAA.TabIndex = 5;
            buttonSave_GAA.Text = "Сохранить";
            buttonSave_GAA.UseVisualStyleBackColor = false;
            buttonSave_GAA.Click += this.buttonSave_GAA_Click;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.BackColor = Color.CornflowerBlue;
            buttonHelp_GAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAA.Location = new Point(567, 16);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(94, 86);
            buttonHelp_GAA.TabIndex = 6;
            buttonHelp_GAA.Text = "Справка";
            buttonHelp_GAA.UseVisualStyleBackColor = false;
            buttonHelp_GAA.Click += this.buttonHelp_GAA_Click;
            // 
            // groupBoxOutput_GAA
            // 
            groupBoxOutput_GAA.Controls.Add(textBoxResult_GAA);
            groupBoxOutput_GAA.Dock = DockStyle.Fill;
            groupBoxOutput_GAA.Location = new Point(0, 0);
            groupBoxOutput_GAA.Name = "groupBoxOutput_GAA";
            groupBoxOutput_GAA.Size = new Size(230, 426);
            groupBoxOutput_GAA.TabIndex = 0;
            groupBoxOutput_GAA.TabStop = false;
            groupBoxOutput_GAA.Text = "Вывод";
            // 
            // textBoxResult_GAA
            // 
            textBoxResult_GAA.Dock = DockStyle.Fill;
            textBoxResult_GAA.Location = new Point(3, 23);
            textBoxResult_GAA.Multiline = true;
            textBoxResult_GAA.Name = "textBoxResult_GAA";
            textBoxResult_GAA.ReadOnly = true;
            textBoxResult_GAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GAA.Size = new Size(224, 400);
            textBoxResult_GAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(tableLayoutPanelMain_GAA);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Гаитова А. А.";
            tableLayoutPanelMain_GAA.ResumeLayout(false);
            splitContainerTop_GAA.Panel1.ResumeLayout(false);
            splitContainerTop_GAA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTop_GAA).EndInit();
            splitContainerTop_GAA.ResumeLayout(false);
            splitContainerBottom_GAA.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerBottom_GAA).EndInit();
            splitContainerBottom_GAA.ResumeLayout(false);
            groupBoxTask_GAA.ResumeLayout(false);
            groupBoxTask_GAA.PerformLayout();
            groupBoxInput_GAA.ResumeLayout(false);
            groupBoxInput_GAA.PerformLayout();
            groupBoxOutput_GAA.ResumeLayout(false);
            groupBoxOutput_GAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain_GAA;
        private SplitContainer splitContainerTop_GAA;
        private SplitContainer splitContainerBottom_GAA;
        private GroupBox groupBoxTask_GAA;
        private TextBox textBoxTask_GAA;
        private GroupBox groupBoxInput_GAA;
        private TextBox textBoxStartStep_GAA;
        private Label labelStartStep_GAA;
        private Button buttonDone_GAA;
        private TextBox textBoxStopStep_GAA;
        private Label labelStopStep_GAA;
        private Button buttonHelp_GAA;
        private Button buttonSave_GAA;
        private GroupBox groupBoxOutput_GAA;
        private TextBox textBoxResult_GAA;
    }
}
