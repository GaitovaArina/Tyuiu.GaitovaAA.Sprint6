namespace Tyuiu.GaitovaAA.Sprint6.Task0.V12
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
            buttonDone_GaitovaAA = new Button();
            buttonHelp_GaitovaAA = new Button();
            labelCondition_GaitovaAA = new Label();
            groupBoxCondition_GaitovaAA = new GroupBox();
            pictureBoxFormula_GaitovaAA = new PictureBox();
            groupBoxInput_GaitovaAA = new GroupBox();
            textBoxVarX_GaitovaAA = new TextBox();
            labelVarX_GaitovaAA = new Label();
            groupBoxOutput_GaitovaAA = new GroupBox();
            textBoxResult_GaitovaAA = new TextBox();
            labelResult_GaitovaAA = new Label();
            groupBoxCondition_GaitovaAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_GaitovaAA).BeginInit();
            groupBoxInput_GaitovaAA.SuspendLayout();
            groupBoxOutput_GaitovaAA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_GaitovaAA
            // 
            buttonDone_GaitovaAA.Location = new Point(566, 387);
            buttonDone_GaitovaAA.Name = "buttonDone_GaitovaAA";
            buttonDone_GaitovaAA.Size = new Size(213, 51);
            buttonDone_GaitovaAA.TabIndex = 0;
            buttonDone_GaitovaAA.Text = "Выполнить";
            buttonDone_GaitovaAA.UseVisualStyleBackColor = true;
            buttonDone_GaitovaAA.Click += buttonDone_GaitovaAA_Click;
            // 
            // buttonHelp_GaitovaAA
            // 
            buttonHelp_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GaitovaAA.Location = new Point(529, 387);
            buttonHelp_GaitovaAA.Name = "buttonHelp_GaitovaAA";
            buttonHelp_GaitovaAA.Size = new Size(31, 51);
            buttonHelp_GaitovaAA.TabIndex = 1;
            buttonHelp_GaitovaAA.Text = "?";
            buttonHelp_GaitovaAA.UseVisualStyleBackColor = true;
            buttonHelp_GaitovaAA.Click += buttonHelp_GaitovaAA_Click;
            // 
            // labelCondition_GaitovaAA
            // 
            labelCondition_GaitovaAA.AutoSize = true;
            labelCondition_GaitovaAA.Location = new Point(6, 36);
            labelCondition_GaitovaAA.Name = "labelCondition_GaitovaAA";
            labelCondition_GaitovaAA.Size = new Size(260, 20);
            labelCondition_GaitovaAA.TabIndex = 3;
            labelCondition_GaitovaAA.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxCondition_GaitovaAA
            // 
            groupBoxCondition_GaitovaAA.Controls.Add(pictureBoxFormula_GaitovaAA);
            groupBoxCondition_GaitovaAA.Controls.Add(labelCondition_GaitovaAA);
            groupBoxCondition_GaitovaAA.Location = new Point(12, 12);
            groupBoxCondition_GaitovaAA.Name = "groupBoxCondition_GaitovaAA";
            groupBoxCondition_GaitovaAA.Size = new Size(776, 125);
            groupBoxCondition_GaitovaAA.TabIndex = 4;
            groupBoxCondition_GaitovaAA.TabStop = false;
            groupBoxCondition_GaitovaAA.Text = "Условие";
            // 
            // pictureBoxFormula_GaitovaAA
            // 
            pictureBoxFormula_GaitovaAA.Image = (Image)resources.GetObject("pictureBoxFormula_GaitovaAA.Image");
            pictureBoxFormula_GaitovaAA.Location = new Point(598, 13);
            pictureBoxFormula_GaitovaAA.Name = "pictureBoxFormula_GaitovaAA";
            pictureBoxFormula_GaitovaAA.Size = new Size(142, 93);
            pictureBoxFormula_GaitovaAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_GaitovaAA.TabIndex = 4;
            pictureBoxFormula_GaitovaAA.TabStop = false;
            // 
            // groupBoxInput_GaitovaAA
            // 
            groupBoxInput_GaitovaAA.Controls.Add(textBoxVarX_GaitovaAA);
            groupBoxInput_GaitovaAA.Controls.Add(labelVarX_GaitovaAA);
            groupBoxInput_GaitovaAA.Location = new Point(12, 313);
            groupBoxInput_GaitovaAA.Name = "groupBoxInput_GaitovaAA";
            groupBoxInput_GaitovaAA.Size = new Size(250, 125);
            groupBoxInput_GaitovaAA.TabIndex = 5;
            groupBoxInput_GaitovaAA.TabStop = false;
            groupBoxInput_GaitovaAA.Text = "Ввод данных";
            // 
            // textBoxVarX_GaitovaAA
            // 
            textBoxVarX_GaitovaAA.Location = new Point(6, 74);
            textBoxVarX_GaitovaAA.Name = "textBoxVarX_GaitovaAA";
            textBoxVarX_GaitovaAA.Size = new Size(28, 27);
            textBoxVarX_GaitovaAA.TabIndex = 6;
            textBoxVarX_GaitovaAA.Text = "3";
            // 
            // labelVarX_GaitovaAA
            // 
            labelVarX_GaitovaAA.AutoSize = true;
            labelVarX_GaitovaAA.Location = new Point(6, 35);
            labelVarX_GaitovaAA.Name = "labelVarX_GaitovaAA";
            labelVarX_GaitovaAA.Size = new Size(114, 20);
            labelVarX_GaitovaAA.TabIndex = 6;
            labelVarX_GaitovaAA.Text = "Переменная X:";
            // 
            // groupBoxOutput_GaitovaAA
            // 
            groupBoxOutput_GaitovaAA.Controls.Add(textBoxResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Controls.Add(labelResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Location = new Point(529, 243);
            groupBoxOutput_GaitovaAA.Name = "groupBoxOutput_GaitovaAA";
            groupBoxOutput_GaitovaAA.Size = new Size(250, 125);
            groupBoxOutput_GaitovaAA.TabIndex = 6;
            groupBoxOutput_GaitovaAA.TabStop = false;
            groupBoxOutput_GaitovaAA.Text = "Вывод данных";
            // 
            // textBoxResult_GaitovaAA
            // 
            textBoxResult_GaitovaAA.Location = new Point(15, 70);
            textBoxResult_GaitovaAA.Name = "textBoxResult_GaitovaAA";
            textBoxResult_GaitovaAA.ReadOnly = true;
            textBoxResult_GaitovaAA.Size = new Size(229, 27);
            textBoxResult_GaitovaAA.TabIndex = 1;
            // 
            // labelResult_GaitovaAA
            // 
            labelResult_GaitovaAA.AutoSize = true;
            labelResult_GaitovaAA.Location = new Point(15, 34);
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
            Controls.Add(groupBoxInput_GaitovaAA);
            Controls.Add(groupBoxCondition_GaitovaAA);
            Controls.Add(buttonHelp_GaitovaAA);
            Controls.Add(buttonDone_GaitovaAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Гаитова А. А.";
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

        private Button buttonDone_GaitovaAA;
        private Button buttonHelp_GaitovaAA;
        private Label labelCondition_GaitovaAA;
        private GroupBox groupBoxCondition_GaitovaAA;
        private PictureBox pictureBoxFormula_GaitovaAA;
        private GroupBox groupBoxInput_GaitovaAA;
        private Label labelVarX_GaitovaAA;
        private TextBox textBoxVarX_GaitovaAA;
        private GroupBox groupBoxOutput_GaitovaAA;
        private Label labelResult_GaitovaAA;
        private TextBox textBoxResult_GaitovaAA;
    }
}
