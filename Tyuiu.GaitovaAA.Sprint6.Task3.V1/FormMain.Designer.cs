namespace Tyuiu.GaitovaAA.Sprint6.Task3.V1
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
            labelCondition_GaitovaAA = new Label();
            dataGridViewMatrix_GaitovaAA = new DataGridView();
            groupBoxOutput_GaitovaAA = new GroupBox();
            textBoxResult_GaitovaAA = new TextBox();
            labelResult_GaitovaAA = new Label();
            buttonHelp_GaitovaAA = new Button();
            buttonDone_GaitovaAA = new Button();
            groupBoxCondition_GaitovaAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GaitovaAA).BeginInit();
            groupBoxOutput_GaitovaAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GaitovaAA
            // 
            groupBoxCondition_GaitovaAA.Controls.Add(labelCondition_GaitovaAA);
            groupBoxCondition_GaitovaAA.Location = new Point(12, 12);
            groupBoxCondition_GaitovaAA.Name = "groupBoxCondition_GaitovaAA";
            groupBoxCondition_GaitovaAA.Size = new Size(439, 478);
            groupBoxCondition_GaitovaAA.TabIndex = 0;
            groupBoxCondition_GaitovaAA.TabStop = false;
            groupBoxCondition_GaitovaAA.Text = "Условие";
            // 
            // labelCondition_GaitovaAA
            // 
            labelCondition_GaitovaAA.Location = new Point(6, 23);
            labelCondition_GaitovaAA.Name = "labelCondition_GaitovaAA";
            labelCondition_GaitovaAA.Size = new Size(499, 452);
            labelCondition_GaitovaAA.TabIndex = 0;
            labelCondition_GaitovaAA.Text = resources.GetString("labelCondition_GaitovaAA.Text");
            // 
            // dataGridViewMatrix_GaitovaAA
            // 
            dataGridViewMatrix_GaitovaAA.AllowUserToAddRows = false;
            dataGridViewMatrix_GaitovaAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GaitovaAA.ColumnHeadersVisible = false;
            dataGridViewMatrix_GaitovaAA.Location = new Point(539, 12);
            dataGridViewMatrix_GaitovaAA.Name = "dataGridViewMatrix_GaitovaAA";
            dataGridViewMatrix_GaitovaAA.ReadOnly = true;
            dataGridViewMatrix_GaitovaAA.RowHeadersVisible = false;
            dataGridViewMatrix_GaitovaAA.RowHeadersWidth = 51;
            dataGridViewMatrix_GaitovaAA.Size = new Size(408, 478);
            dataGridViewMatrix_GaitovaAA.TabIndex = 1;
            // 
            // groupBoxOutput_GaitovaAA
            // 
            groupBoxOutput_GaitovaAA.Controls.Add(textBoxResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Controls.Add(labelResult_GaitovaAA);
            groupBoxOutput_GaitovaAA.Location = new Point(968, 12);
            groupBoxOutput_GaitovaAA.Name = "groupBoxOutput_GaitovaAA";
            groupBoxOutput_GaitovaAA.Size = new Size(286, 393);
            groupBoxOutput_GaitovaAA.TabIndex = 2;
            groupBoxOutput_GaitovaAA.TabStop = false;
            groupBoxOutput_GaitovaAA.Text = "Вывод данных";
            // 
            // textBoxResult_GaitovaAA
            // 
            textBoxResult_GaitovaAA.Location = new Point(6, 59);
            textBoxResult_GaitovaAA.Name = "textBoxResult_GaitovaAA";
            textBoxResult_GaitovaAA.ReadOnly = true;
            textBoxResult_GaitovaAA.Size = new Size(240, 27);
            textBoxResult_GaitovaAA.TabIndex = 1;
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
            // buttonHelp_GaitovaAA
            // 
            buttonHelp_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GaitovaAA.Location = new Point(1021, 425);
            buttonHelp_GaitovaAA.Name = "buttonHelp_GaitovaAA";
            buttonHelp_GaitovaAA.Size = new Size(51, 65);
            buttonHelp_GaitovaAA.TabIndex = 3;
            buttonHelp_GaitovaAA.Text = "?";
            buttonHelp_GaitovaAA.UseVisualStyleBackColor = true;
            buttonHelp_GaitovaAA.Click += buttonHelp_GaitovaAA_Click;
            // 
            // buttonDone_GaitovaAA
            // 
            buttonDone_GaitovaAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GaitovaAA.Location = new Point(1091, 425);
            buttonDone_GaitovaAA.Name = "buttonDone_GaitovaAA";
            buttonDone_GaitovaAA.Size = new Size(163, 65);
            buttonDone_GaitovaAA.TabIndex = 4;
            buttonDone_GaitovaAA.Text = "Выполнить";
            buttonDone_GaitovaAA.UseVisualStyleBackColor = true;
            buttonDone_GaitovaAA.Click += buttonDone_GaitovaAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 502);
            Controls.Add(buttonDone_GaitovaAA);
            Controls.Add(buttonHelp_GaitovaAA);
            Controls.Add(groupBoxOutput_GaitovaAA);
            Controls.Add(dataGridViewMatrix_GaitovaAA);
            Controls.Add(groupBoxCondition_GaitovaAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 1 | Гаитова А. А.";
            groupBoxCondition_GaitovaAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GaitovaAA).EndInit();
            groupBoxOutput_GaitovaAA.ResumeLayout(false);
            groupBoxOutput_GaitovaAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GaitovaAA;
        private Label labelCondition_GaitovaAA;
        private DataGridView dataGridViewMatrix_GaitovaAA;
        private GroupBox groupBoxOutput_GaitovaAA;
        private TextBox textBoxResult_GaitovaAA;
        private Label labelResult_GaitovaAA;
        private Button buttonHelp_GaitovaAA;
        private Button buttonDone_GaitovaAA;
    }
}
