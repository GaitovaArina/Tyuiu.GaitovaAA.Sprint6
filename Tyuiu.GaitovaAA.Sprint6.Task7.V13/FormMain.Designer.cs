namespace Tyuiu.GaitovaAA.Sprint6.Task7.V13
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tableLayoutPanelMain_GAA = new TableLayoutPanel();
            panelButtons_GAA = new Panel();
            buttonHelp_GAA = new Button();
            buttonSaveFile_GAA = new Button();
            buttonDone_GAA = new Button();
            buttonOpenFile_GAA = new Button();
            groupBoxTask_GAA = new GroupBox();
            textBoxTask_GAA = new TextBox();
            splitContainerMain_GAA = new SplitContainer();
            groupBoxIn_GAA = new GroupBox();
            dataGridViewIn_GAA = new DataGridView();
            groupBoxOut_GAA = new GroupBox();
            dataGridViewOut_GAA = new DataGridView();
            openFileDialogTask_GAA = new OpenFileDialog();
            saveFileDialogMatrix_GAA = new SaveFileDialog();
            toolTipButton_GAA = new ToolTip(components);
            tableLayoutPanelMain_GAA.SuspendLayout();
            panelButtons_GAA.SuspendLayout();
            groupBoxTask_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_GAA).BeginInit();
            splitContainerMain_GAA.Panel1.SuspendLayout();
            splitContainerMain_GAA.Panel2.SuspendLayout();
            splitContainerMain_GAA.SuspendLayout();
            groupBoxIn_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GAA).BeginInit();
            groupBoxOut_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GAA).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain_GAA
            // 
            tableLayoutPanelMain_GAA.ColumnCount = 1;
            tableLayoutPanelMain_GAA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanelMain_GAA.Controls.Add(panelButtons_GAA, 0, 0);
            tableLayoutPanelMain_GAA.Controls.Add(groupBoxTask_GAA, 0, 1);
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerMain_GAA, 0, 2);
            tableLayoutPanelMain_GAA.Dock = DockStyle.Fill;
            tableLayoutPanelMain_GAA.Location = new Point(0, 0);
            tableLayoutPanelMain_GAA.Name = "tableLayoutPanelMain_GAA";
            tableLayoutPanelMain_GAA.RowCount = 3;
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanelMain_GAA.Size = new Size(800, 450);
            tableLayoutPanelMain_GAA.TabIndex = 0;
            // 
            // panelButtons_GAA
            // 
            panelButtons_GAA.Controls.Add(buttonHelp_GAA);
            panelButtons_GAA.Controls.Add(buttonSaveFile_GAA);
            panelButtons_GAA.Controls.Add(buttonDone_GAA);
            panelButtons_GAA.Controls.Add(buttonOpenFile_GAA);
            panelButtons_GAA.Dock = DockStyle.Fill;
            panelButtons_GAA.Location = new Point(3, 3);
            panelButtons_GAA.Name = "panelButtons_GAA";
            panelButtons_GAA.Size = new Size(794, 59);
            panelButtons_GAA.TabIndex = 0;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAA.BackgroundImage = (Image)resources.GetObject("buttonHelp_GAA.BackgroundImage");
            buttonHelp_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_GAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAA.Location = new Point(736, 1);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(55, 55);
            buttonHelp_GAA.TabIndex = 3;
            buttonHelp_GAA.UseVisualStyleBackColor = true;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            buttonHelp_GAA.MouseEnter += buttonHelp_GAA_MouseEnter;
            // 
            // buttonSaveFile_GAA
            // 
            buttonSaveFile_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_GAA.Enabled = false;
            buttonSaveFile_GAA.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_GAA.Image = (Image)resources.GetObject("buttonSaveFile_GAA.Image");
            buttonSaveFile_GAA.Location = new Point(125, 4);
            buttonSaveFile_GAA.Name = "buttonSaveFile_GAA";
            buttonSaveFile_GAA.Size = new Size(55, 55);
            buttonSaveFile_GAA.TabIndex = 2;
            buttonSaveFile_GAA.UseVisualStyleBackColor = true;
            buttonSaveFile_GAA.Click += buttonSaveFile_GAA_Click;
            buttonSaveFile_GAA.MouseEnter += buttonSaveFile_GAA_MouseEnter;
            // 
            // buttonDone_GAA
            // 
            buttonDone_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_GAA.Enabled = false;
            buttonDone_GAA.FlatStyle = FlatStyle.Flat;
            buttonDone_GAA.Image = (Image)resources.GetObject("buttonDone_GAA.Image");
            buttonDone_GAA.Location = new Point(64, 3);
            buttonDone_GAA.Name = "buttonDone_GAA";
            buttonDone_GAA.Size = new Size(55, 55);
            buttonDone_GAA.TabIndex = 1;
            buttonDone_GAA.UseVisualStyleBackColor = true;
            buttonDone_GAA.Click += buttonDone_GAA_Click;
            buttonDone_GAA.MouseEnter += buttonDone_GAA_MouseEnter;
            // 
            // buttonOpenFile_GAA
            // 
            buttonOpenFile_GAA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_GAA.BackgroundImage");
            buttonOpenFile_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_GAA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_GAA.Location = new Point(3, 4);
            buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            buttonOpenFile_GAA.Size = new Size(55, 55);
            buttonOpenFile_GAA.TabIndex = 0;
            buttonOpenFile_GAA.UseVisualStyleBackColor = true;
            buttonOpenFile_GAA.Click += buttonOpenFile_GAA_Click;
            buttonOpenFile_GAA.MouseEnter += buttonOpenFile_GAA_MouseEnter;
            // 
            // groupBoxTask_GAA
            // 
            groupBoxTask_GAA.Controls.Add(textBoxTask_GAA);
            groupBoxTask_GAA.Dock = DockStyle.Fill;
            groupBoxTask_GAA.Location = new Point(3, 68);
            groupBoxTask_GAA.Name = "groupBoxTask_GAA";
            groupBoxTask_GAA.Size = new Size(794, 109);
            groupBoxTask_GAA.TabIndex = 1;
            groupBoxTask_GAA.TabStop = false;
            groupBoxTask_GAA.Text = "Условие:";
            // 
            // textBoxTask_GAA
            // 
            textBoxTask_GAA.BorderStyle = BorderStyle.None;
            textBoxTask_GAA.Dock = DockStyle.Fill;
            textBoxTask_GAA.Location = new Point(3, 23);
            textBoxTask_GAA.Multiline = true;
            textBoxTask_GAA.Name = "textBoxTask_GAA";
            textBoxTask_GAA.ReadOnly = true;
            textBoxTask_GAA.Size = new Size(788, 83);
            textBoxTask_GAA.TabIndex = 0;
            textBoxTask_GAA.Text = resources.GetString("textBoxTask_GAA.Text");
            // 
            // splitContainerMain_GAA
            // 
            splitContainerMain_GAA.Dock = DockStyle.Fill;
            splitContainerMain_GAA.Location = new Point(3, 183);
            splitContainerMain_GAA.Name = "splitContainerMain_GAA";
            // 
            // splitContainerMain_GAA.Panel1
            // 
            splitContainerMain_GAA.Panel1.Controls.Add(groupBoxIn_GAA);
            // 
            // splitContainerMain_GAA.Panel2
            // 
            splitContainerMain_GAA.Panel2.Controls.Add(groupBoxOut_GAA);
            splitContainerMain_GAA.Size = new Size(794, 264);
            splitContainerMain_GAA.SplitterDistance = 264;
            splitContainerMain_GAA.TabIndex = 2;
            // 
            // groupBoxIn_GAA
            // 
            groupBoxIn_GAA.Controls.Add(dataGridViewIn_GAA);
            groupBoxIn_GAA.Dock = DockStyle.Fill;
            groupBoxIn_GAA.Location = new Point(0, 0);
            groupBoxIn_GAA.Name = "groupBoxIn_GAA";
            groupBoxIn_GAA.Size = new Size(264, 264);
            groupBoxIn_GAA.TabIndex = 0;
            groupBoxIn_GAA.TabStop = false;
            groupBoxIn_GAA.Text = "Ввод:";
            // 
            // dataGridViewIn_GAA
            // 
            dataGridViewIn_GAA.AllowUserToAddRows = false;
            dataGridViewIn_GAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_GAA.ColumnHeadersVisible = false;
            dataGridViewIn_GAA.Dock = DockStyle.Fill;
            dataGridViewIn_GAA.Location = new Point(3, 23);
            dataGridViewIn_GAA.Name = "dataGridViewIn_GAA";
            dataGridViewIn_GAA.ReadOnly = true;
            dataGridViewIn_GAA.RowHeadersVisible = false;
            dataGridViewIn_GAA.RowHeadersWidth = 51;
            dataGridViewIn_GAA.Size = new Size(258, 238);
            dataGridViewIn_GAA.TabIndex = 0;
            // 
            // groupBoxOut_GAA
            // 
            groupBoxOut_GAA.Controls.Add(dataGridViewOut_GAA);
            groupBoxOut_GAA.Dock = DockStyle.Fill;
            groupBoxOut_GAA.Location = new Point(0, 0);
            groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            groupBoxOut_GAA.Size = new Size(526, 264);
            groupBoxOut_GAA.TabIndex = 0;
            groupBoxOut_GAA.TabStop = false;
            groupBoxOut_GAA.Text = "Вывод:";
            // 
            // dataGridViewOut_GAA
            // 
            dataGridViewOut_GAA.AllowUserToAddRows = false;
            dataGridViewOut_GAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_GAA.ColumnHeadersVisible = false;
            dataGridViewOut_GAA.Dock = DockStyle.Fill;
            dataGridViewOut_GAA.Location = new Point(3, 23);
            dataGridViewOut_GAA.Name = "dataGridViewOut_GAA";
            dataGridViewOut_GAA.ReadOnly = true;
            dataGridViewOut_GAA.RowHeadersVisible = false;
            dataGridViewOut_GAA.RowHeadersWidth = 51;
            dataGridViewOut_GAA.Size = new Size(520, 238);
            dataGridViewOut_GAA.TabIndex = 0;
            // 
            // openFileDialogTask_GAA
            // 
            openFileDialogTask_GAA.FileName = "openFileDialog1";
            openFileDialogTask_GAA.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            // 
            // saveFileDialogMatrix_GAA
            // 
            saveFileDialogMatrix_GAA.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            // 
            // toolTipButton_GAA
            // 
            toolTipButton_GAA.IsBalloon = true;
            toolTipButton_GAA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelMain_GAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Гаитова А. А.";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanelMain_GAA.ResumeLayout(false);
            panelButtons_GAA.ResumeLayout(false);
            groupBoxTask_GAA.ResumeLayout(false);
            groupBoxTask_GAA.PerformLayout();
            splitContainerMain_GAA.Panel1.ResumeLayout(false);
            splitContainerMain_GAA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_GAA).EndInit();
            splitContainerMain_GAA.ResumeLayout(false);
            groupBoxIn_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GAA).EndInit();
            groupBoxOut_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain_GAA;
        private Panel panelButtons_GAA;
        private Button buttonOpenFile_GAA;
        private Button buttonSaveFile_GAA;
        private Button buttonDone_GAA;
        private Button buttonHelp_GAA;
        private GroupBox groupBoxTask_GAA;
        private TextBox textBoxTask_GAA;
        private SplitContainer splitContainerMain_GAA;
        private GroupBox groupBoxIn_GAA;
        private DataGridView dataGridViewIn_GAA;
        private GroupBox groupBoxOut_GAA;
        private DataGridView dataGridViewOut_GAA;
        private OpenFileDialog openFileDialogTask_GAA;
        private SaveFileDialog saveFileDialogMatrix_GAA;
        private ToolTip toolTipButton_GAA;
    }
}
