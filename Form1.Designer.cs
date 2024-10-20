namespace HalloweenHangman
{
    partial class Form1
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
            btnSubmit = new Button();
            lblHangmanWord = new Label();
            pbHangman = new PictureBox();
            txtLetter = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHangman).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.FlatAppearance.BorderColor = Color.White;
            btnSubmit.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.FromArgb(128, 64, 0);
            btnSubmit.Location = new Point(160, 439);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(251, 34);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit your guess";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblHangmanWord
            // 
            lblHangmanWord.AutoSize = true;
            lblHangmanWord.BackColor = Color.FromArgb(255, 192, 128);
            lblHangmanWord.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHangmanWord.Location = new Point(171, 60);
            lblHangmanWord.MaximumSize = new Size(300, 60);
            lblHangmanWord.MinimumSize = new Size(250, 30);
            lblHangmanWord.Name = "lblHangmanWord";
            lblHangmanWord.Size = new Size(250, 30);
            lblHangmanWord.TabIndex = 1;
            lblHangmanWord.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbHangman
            // 
            pbHangman.Image = Properties.Resources.Welcome;
            pbHangman.Location = new Point(107, 115);
            pbHangman.Name = "pbHangman";
            pbHangman.Size = new Size(381, 203);
            pbHangman.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHangman.TabIndex = 2;
            pbHangman.TabStop = false;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(160, 376);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(249, 31);
            txtLetter.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(138, 338);
            label1.Name = "label1";
            label1.Size = new Size(296, 26);
            label1.TabIndex = 4;
            label1.Text = "Please type a letter below:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(567, 512);
            Controls.Add(label1);
            Controls.Add(txtLetter);
            Controls.Add(pbHangman);
            Controls.Add(lblHangmanWord);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Halloween Hangman Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblHangmanWord;
        private PictureBox pbHangman;
        private TextBox txtLetter;
        private Label label1;
    }
}
