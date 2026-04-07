namespace Blackjack
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
            buttonShuffle = new Button();
            buttonDraw = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonShuffle
            // 
            buttonShuffle.Location = new Point(224, 239);
            buttonShuffle.Name = "buttonShuffle";
            buttonShuffle.Size = new Size(94, 29);
            buttonShuffle.TabIndex = 0;
            buttonShuffle.Text = "Shuffle";
            buttonShuffle.UseVisualStyleBackColor = true;
            buttonShuffle.Click += buttonShuffle_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(346, 239);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(94, 29);
            buttonDraw.TabIndex = 1;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(483, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 117);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(buttonDraw);
            Controls.Add(buttonShuffle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShuffle;
        private Button buttonDraw;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
