namespace Tyuiu.GaitovaAA.Sprint6.Task6.V30
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
            openFileDialogTask_GAA = new OpenFileDialog();
            tableLayoutPanelMain_GAA = new TableLayoutPanel();
            panelButtons_GAA = new Panel();
            buttonHelp_GAA = new Button();
            buttonOpenFile_GAA = new Button();
            buttonDone_GAA = new Button();
            groupBoxTask_GAA = new GroupBox();
            textBoxTask_GAA = new TextBox();
            splitContainerMain_GAA = new SplitContainer();
            groupBoxIn_GAA = new GroupBox();
            textBoxIn_GAA = new TextBox();
            groupBoxOut_GAA = new GroupBox();
            textBoxOut_GAA = new TextBox();
            toolTipTask_GAA = new ToolTip(components);
            tableLayoutPanelMain_GAA.SuspendLayout();
            panelButtons_GAA.SuspendLayout();
            groupBoxTask_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_GAA).BeginInit();
            splitContainerMain_GAA.Panel1.SuspendLayout();
            splitContainerMain_GAA.Panel2.SuspendLayout();
            splitContainerMain_GAA.SuspendLayout();
            groupBoxIn_GAA.SuspendLayout();
            groupBoxOut_GAA.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask_GAA
            // 
            openFileDialogTask_GAA.FileName = "openFileDialog1";
            // 
            // tableLayoutPanelMain_GAA
            // 
            tableLayoutPanelMain_GAA.ColumnCount = 1;
            tableLayoutPanelMain_GAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain_GAA.Controls.Add(panelButtons_GAA, 0, 0);
            tableLayoutPanelMain_GAA.Controls.Add(groupBoxTask_GAA, 0, 1);
            tableLayoutPanelMain_GAA.Controls.Add(splitContainerMain_GAA, 0, 2);
            tableLayoutPanelMain_GAA.Dock = DockStyle.Fill;
            tableLayoutPanelMain_GAA.Location = new Point(0, 0);
            tableLayoutPanelMain_GAA.Name = "tableLayoutPanelMain_GAA";
            tableLayoutPanelMain_GAA.RowCount = 3;
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanelMain_GAA.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain_GAA.Size = new Size(932, 503);
            tableLayoutPanelMain_GAA.TabIndex = 0;
            // 
            // panelButtons_GAA
            // 
            panelButtons_GAA.Controls.Add(buttonHelp_GAA);
            panelButtons_GAA.Controls.Add(buttonOpenFile_GAA);
            panelButtons_GAA.Controls.Add(buttonDone_GAA);
            panelButtons_GAA.Dock = DockStyle.Fill;
            panelButtons_GAA.Location = new Point(3, 3);
            panelButtons_GAA.Name = "panelButtons_GAA";
            panelButtons_GAA.Size = new Size(926, 59);
            panelButtons_GAA.TabIndex = 0;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAA.BackgroundImage = (Image)resources.GetObject("buttonHelp_GAA.BackgroundImage");
            buttonHelp_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_GAA.Location = new Point(857, 0);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(60, 60);
            buttonHelp_GAA.TabIndex = 2;
            buttonHelp_GAA.UseVisualStyleBackColor = true;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // buttonOpenFile_GAA
            // 
            buttonOpenFile_GAA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_GAA.BackgroundImage");
            buttonOpenFile_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_GAA.Location = new Point(9, 4);
            buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            buttonOpenFile_GAA.Size = new Size(56, 53);
            buttonOpenFile_GAA.TabIndex = 0;
            buttonOpenFile_GAA.UseVisualStyleBackColor = true;
            buttonOpenFile_GAA.Click += buttonOpenFile_GAA_Click;
            // 
            // buttonDone_GAA
            // 
            buttonDone_GAA.BackgroundImage = (Image)resources.GetObject("buttonDone_GAA.BackgroundImage");
            buttonDone_GAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_GAA.Enabled = false;
            buttonDone_GAA.Location = new Point(83, 3);
            buttonDone_GAA.Name = "buttonDone_GAA";
            buttonDone_GAA.Size = new Size(60, 56);
            buttonDone_GAA.TabIndex = 1;
            buttonDone_GAA.UseVisualStyleBackColor = true;
            buttonDone_GAA.Click += buttonDone_GAA_Click;
            // 
            // groupBoxTask_GAA
            // 
            groupBoxTask_GAA.Controls.Add(textBoxTask_GAA);
            groupBoxTask_GAA.Dock = DockStyle.Fill;
            groupBoxTask_GAA.Location = new Point(3, 68);
            groupBoxTask_GAA.Name = "groupBoxTask_GAA";
            groupBoxTask_GAA.Size = new Size(926, 79);
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
            textBoxTask_GAA.Size = new Size(920, 53);
            textBoxTask_GAA.TabIndex = 0;
            textBoxTask_GAA.Text = resources.GetString("textBoxTask_GAA.Text");
            // 
            // splitContainerMain_GAA
            // 
            splitContainerMain_GAA.Dock = DockStyle.Fill;
            splitContainerMain_GAA.Location = new Point(3, 153);
            splitContainerMain_GAA.Name = "splitContainerMain_GAA";
            // 
            // splitContainerMain_GAA.Panel1
            // 
            splitContainerMain_GAA.Panel1.Controls.Add(groupBoxIn_GAA);
            // 
            // splitContainerMain_GAA.Panel2
            // 
            splitContainerMain_GAA.Panel2.Controls.Add(groupBoxOut_GAA);
            splitContainerMain_GAA.Size = new Size(926, 347);
            splitContainerMain_GAA.SplitterDistance = 424;
            splitContainerMain_GAA.TabIndex = 2;
            // 
            // groupBoxIn_GAA
            // 
            groupBoxIn_GAA.Controls.Add(textBoxIn_GAA);
            groupBoxIn_GAA.Dock = DockStyle.Fill;
            groupBoxIn_GAA.Location = new Point(0, 0);
            groupBoxIn_GAA.Name = "groupBoxIn_GAA";
            groupBoxIn_GAA.Size = new Size(424, 347);
            groupBoxIn_GAA.TabIndex = 0;
            groupBoxIn_GAA.TabStop = false;
            groupBoxIn_GAA.Text = "Ввод:";
            // 
            // textBoxIn_GAA
            // 
            textBoxIn_GAA.Dock = DockStyle.Fill;
            textBoxIn_GAA.Location = new Point(3, 23);
            textBoxIn_GAA.Multiline = true;
            textBoxIn_GAA.Name = "textBoxIn_GAA";
            textBoxIn_GAA.ReadOnly = true;
            textBoxIn_GAA.ScrollBars = ScrollBars.Both;
            textBoxIn_GAA.Size = new Size(418, 321);
            textBoxIn_GAA.TabIndex = 0;
            // 
            // groupBoxOut_GAA
            // 
            groupBoxOut_GAA.Controls.Add(textBoxOut_GAA);
            groupBoxOut_GAA.Dock = DockStyle.Fill;
            groupBoxOut_GAA.Location = new Point(0, 0);
            groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            groupBoxOut_GAA.Size = new Size(498, 347);
            groupBoxOut_GAA.TabIndex = 0;
            groupBoxOut_GAA.TabStop = false;
            groupBoxOut_GAA.Text = "Вывод:";
            // 
            // textBoxOut_GAA
            // 
            textBoxOut_GAA.Dock = DockStyle.Fill;
            textBoxOut_GAA.Location = new Point(3, 23);
            textBoxOut_GAA.Multiline = true;
            textBoxOut_GAA.Name = "textBoxOut_GAA";
            textBoxOut_GAA.ReadOnly = true;
            textBoxOut_GAA.ScrollBars = ScrollBars.Both;
            textBoxOut_GAA.Size = new Size(492, 321);
            textBoxOut_GAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(tableLayoutPanelMain_GAA);
            MinimumSize = new Size(750, 420);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 30 | Гаитова А. А.";
            tableLayoutPanelMain_GAA.ResumeLayout(false);
            panelButtons_GAA.ResumeLayout(false);
            groupBoxTask_GAA.ResumeLayout(false);
            groupBoxTask_GAA.PerformLayout();
            splitContainerMain_GAA.Panel1.ResumeLayout(false);
            splitContainerMain_GAA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_GAA).EndInit();
            splitContainerMain_GAA.ResumeLayout(false);
            groupBoxIn_GAA.ResumeLayout(false);
            groupBoxIn_GAA.PerformLayout();
            groupBoxOut_GAA.ResumeLayout(false);
            groupBoxOut_GAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask_GAA;
        private TableLayoutPanel tableLayoutPanelMain_GAA;
        private Panel panelButtons_GAA;
        private Button buttonOpenFile_GAA;
        private Button buttonHelp_GAA;
        private Button buttonDone_GAA;
        private GroupBox groupBoxTask_GAA;
        private TextBox textBoxTask_GAA;
        private SplitContainer splitContainerMain_GAA;
        private GroupBox groupBoxIn_GAA;
        private TextBox textBoxIn_GAA;
        private GroupBox groupBoxOut_GAA;
        private TextBox textBoxOut_GAA;
        private ToolTip toolTipTask_GAA;
    }
}
