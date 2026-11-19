namespace Tyuiu.GaitovaAA.Sprint6.Task1.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_GaitovaAA = new GroupBox();
            pictureBoxFormula_GaitovaAA = new PictureBox();
            labelCondition_GaitovaAA = new Label();
            groupBoxInput_GaitovaAA = new GroupBox();
            textBoxStop_GaitovaAA = new TextBox();
            labelStop_GaitovaAA = new Label();
            textBoxStart_GaitovaAA = new TextBox();
            labelStart_GaitovaAA = new Label();
            buttonHelp_GaitovaAA = new Button();
            buttonDone_GaitovaAA = new Button();
            groupBoxOutput_GaitovaAA = new GroupBox();
            textBoxResult_GaitovaAA = new TextBox();
            labelResult_GaitovaAA = new Label();
            groupBoxCondition_GaitovaAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_GaitovaAA).BeginInit();
            groupBoxInput_GaitovaAA.SuspendLayout();
            groupBoxOutput_GaitovaAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GaitovaAA
            // 
            groupBoxCondition_GaitovaAA.Controls.Add(pictureBoxFormula_GaitovaAA);
            groupBoxCondition_GaitovaAA.Controls.Add(labelCondition_GaitovaAA);
            groupBoxCondition_GaitovaAA.Location = new Point(12, 12);
            groupBoxCondition_GaitovaAA.Name = "groupBoxCondition_GaitovaAA";
            groupBoxCondition_GaitovaAA.Size = new Size(537, 315);
            groupBoxCondition_GaitovaAA.TabIndex = 0;
            groupBoxCondition_GaitovaAA.TabStop = false;
            groupBoxCondition_GaitovaAA.Text = "Условие";
            // 
            // pictureBoxFormula_GaitovaAA
            // 
            pictureBoxFormula_GaitovaAA.Image = (Image)resources.GetObject("pictureBoxFormula_GaitovaAA.Image");
            pictureBoxFormula_GaitovaAA.Location = new Point(16, 69);
            pictureBoxFormula_GaitovaAA.Name = "pictureBoxFormula_GaitovaAA";
            pictureBoxFormula_GaitovaAA.Size = new Size(304, 44);
            pictureBoxFormula_GaitovaAA.TabIndex = 1;
            pictureBoxFormula_GaitovaAA.TabStop = false;
            // 
            // labelCondition_GaitovaAA
            // 
            labelCondition_GaitovaAA.AutoSize = true;
            labelCondition_GaitovaAA.Location = new Point(6, 34);
            labelCondition_GaitovaAA.Name = "labelCondition_GaitovaAA";
            labelCondition_GaitovaAA.Size = new Size(475, 20);
            labelCondition_GaitovaAA.TabIndex = 0;
            labelCondition_GaitovaAA.Text = "Протабулировать функцию F(x) = (5x + 2,5)/(sin(x) + 3) + 2x + cos(x)";
            // 
            // groupBoxInput_GaitovaAA
            // 
            groupBoxInput_GaitovaAA.Controls.Add(textBoxStop_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(labelStop_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(textBoxStart_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(labelStart_GaitovaAA);
            groupBoxInput_GaitovaAA.Location = new Point(12, 333);
            groupBoxInput_GaitovaAA.Name = "groupBoxInput_GaitovaAA";
            groupBoxInput_GaitovaAA.Size = new Size(290, 115);
            groupBoxInput_GaitovaAA.TabIndex = 1;
            groupBoxInput_GaitovaAA.TabStop = false;
            groupBoxInput_GaitovaAA.Text = "Ввод данных";
            // 
            // textBoxStop_GaitovaAA
            // 
            textBoxStop_GaitovaAA.Location = new Point(151, 59);
            textBoxStop_GaitovaAA.Name = "textBoxStop_GaitovaAA";
            textBoxStop_GaitovaAA.Size = new Size(125, 27);
            textBoxStop_GaitovaAA.TabIndex = 2;
            textBoxStop_GaitovaAA.Text = "5";
            // 
            // labelStop_GaitovaAA
            // 
            labelStop_GaitovaAA.AutoSize = true;
            labelStop_GaitovaAA.Location = new Point(151, 23);
            labelStop_GaitovaAA.Name = "labelStop_GaitovaAA";
            labelStop_GaitovaAA.Size = new Size(94, 20);
            labelStop_GaitovaAA.TabIndex = 2;
            labelStop_GaitovaAA.Text = "Конец шага:";
            // 
            // textBoxStart_GaitovaAA
            // 
            textBoxStart_GaitovaAA.Location = new Point(6, 59);
            textBoxStart_GaitovaAA.Name = "textBoxStart_GaitovaAA";
            textBoxStart_GaitovaAA.Size = new Size(88, 27);
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
            buttonHelp_GaitovaAA.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp_GaitovaAA.Location = new Point(308, 347);
            buttonHelp_GaitovaAA.Name = "buttonHelp_GaitovaAA";
            buttonHelp_GaitovaAA.Size = new Size(88, 91);
            buttonHelp_GaitovaAA.TabIndex = 2;
            buttonHelp_GaitovaAA.Text = "Справка";
            buttonHelp_GaitovaAA.UseVisualStyleBackColor = false;
            buttonHelp_GaitovaAA.Click += buttonHelp_GaitovaAA_Click;
            // 
            // buttonDone_GaitovaAA
            // 
            buttonDone_GaitovaAA.BackColor = Color.ForestGreen;
            buttonDone_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GaitovaAA.Location = new Point(401, 347);
            buttonDone_GaitovaAA.Name = "buttonDone_GaitovaAA";
            buttonDone_GaitovaAA.Size = new Size(148, 91);
            buttonDone_GaitovaAA.TabIndex = 3;
            buttonDone_GaitovaAA.Text = "Выполнить";
            buttonDone_GaitovaAA.UseVisualStyleBackColor = false;
            buttonDone_GaitovaAA.Click += buttonDone_GaitovaAA_Click;
            // 
            // groupBoxOutput_GaitovaAA
            // 
            groupBoxOutput_GaitovaAA.Controls.Add(textBoxResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Controls.Add(labelResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Location = new Point(555, 12);
            groupBoxOutput_GaitovaAA.Name = "groupBoxOutput_GaitovaAA";
            groupBoxOutput_GaitovaAA.Size = new Size(233, 426);
            groupBoxOutput_GaitovaAA.TabIndex = 4;
            groupBoxOutput_GaitovaAA.TabStop = false;
            groupBoxOutput_GaitovaAA.Text = "Вывод данных";
            // 
            // textBoxResult_GaitovaAA
            // 
            textBoxResult_GaitovaAA.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_GaitovaAA.Location = new Point(6, 57);
            textBoxResult_GaitovaAA.Multiline = true;
            textBoxResult_GaitovaAA.Name = "textBoxResult_GaitovaAA";
            textBoxResult_GaitovaAA.ReadOnly = true;
            textBoxResult_GaitovaAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GaitovaAA.Size = new Size(221, 363);
            textBoxResult_GaitovaAA.TabIndex = 1;
            // 
            // labelResult_GaitovaAA
            // 
            labelResult_GaitovaAA.AutoSize = true;
            labelResult_GaitovaAA.Location = new Point(6, 34);
            labelResult_GaitovaAA.Name = "labelResult_GaitovaAA";
            labelResult_GaitovaAA.Size = new Size(78, 20);
            labelResult_GaitovaAA.TabIndex = 0;
            labelResult_GaitovaAA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_GaitovaAA);
            Controls.Add(buttonDone_GaitovaAA);
            Controls.Add(buttonHelp_GaitovaAA);
            Controls.Add(groupBoxInput_GaitovaAA);
            Controls.Add(groupBoxCondition_GaitovaAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 11 | Гаитова А. А.";
            groupBoxCondition_GaitovaAA.ResumeLayout(false);
            groupBoxCondition_GaitovaAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_GaitovaAA).EndInit();
            groupBoxInput_GaitovaAA.ResumeLayout(false);
            groupBoxInput_GaitovaAA.PerformLayout();
            groupBoxOutput_GaitovaAA.ResumeLayout(false);
            groupBoxOutput_GaitovaAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GaitovaAA;
        private PictureBox pictureBoxFormula_GaitovaAA;
        private Label labelCondition_GaitovaAA;
        private GroupBox groupBoxInput_GaitovaAA;
        private Label labelStop_GaitovaAA;
        private TextBox textBoxStart_GaitovaAA;
        private Label labelStart_GaitovaAA;
        private TextBox textBoxStop_GaitovaAA;
        private Button buttonHelp_GaitovaAA;
        private Button buttonDone_GaitovaAA;
        private GroupBox groupBoxOutput_GaitovaAA;
        private TextBox textBoxResult_GaitovaAA;
        private Label labelResult_GaitovaAA;
    }
}
