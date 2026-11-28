namespace Tyuiu.GaitovaAA.Sprint6.Task7.V13
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAuthor_GAA = new PictureBox();
            labelAbout_GAA = new Label();
            buttonOk_GAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_GAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAuthor_GAA
            // 
            pictureBoxAuthor_GAA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAuthor_GAA.Image = (Image)resources.GetObject("pictureBoxAuthor_GAA.Image");
            pictureBoxAuthor_GAA.Location = new Point(15, 15);
            pictureBoxAuthor_GAA.Name = "pictureBoxAuthor_GAA";
            pictureBoxAuthor_GAA.Size = new Size(135, 175);
            pictureBoxAuthor_GAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAuthor_GAA.TabIndex = 0;
            pictureBoxAuthor_GAA.TabStop = false;
            // 
            // labelAbout_GAA
            // 
            labelAbout_GAA.AutoSize = true;
            labelAbout_GAA.Location = new Point(165, 15);
            labelAbout_GAA.Name = "labelAbout_GAA";
            labelAbout_GAA.Size = new Size(387, 180);
            labelAbout_GAA.TabIndex = 1;
            labelAbout_GAA.Text = resources.GetString("labelAbout_GAA.Text");
            // 
            // buttonOk_GAA
            // 
            buttonOk_GAA.FlatStyle = FlatStyle.Flat;
            buttonOk_GAA.Location = new Point(459, 215);
            buttonOk_GAA.Name = "buttonOk_GAA";
            buttonOk_GAA.Size = new Size(85, 30);
            buttonOk_GAA.TabIndex = 2;
            buttonOk_GAA.Text = "ОК";
            buttonOk_GAA.UseVisualStyleBackColor = true;
            buttonOk_GAA.Click += this.buttonOk_GAA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 256);
            Controls.Add(buttonOk_GAA);
            Controls.Add(labelAbout_GAA);
            Controls.Add(pictureBoxAuthor_GAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_GAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAuthor_GAA;
        private Label labelAbout_GAA;
        private Button buttonOk_GAA;
    }
}