namespace Word
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.TextBox textBox_numberOfWords;
        private System.Windows.Forms.Button button_setNumberOfWords;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_word = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_score = new System.Windows.Forms.Label();
            this.textBox_numberOfWords = new System.Windows.Forms.TextBox();
            this.button_setNumberOfWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_word.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_word.Location = new System.Drawing.Point(65, 37);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(303, 68);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guess
            // 
            this.textBox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_guess.Location = new System.Drawing.Point(63, 131);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(305, 53);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_guess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.PowderBlue;
            this.button_next.Enabled = false;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_next.Location = new System.Drawing.Point(63, 215);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(305, 75);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.DimGray;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_result.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_result.Location = new System.Drawing.Point(65, 397);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(303, 68);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.PowderBlue;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_start.Location = new System.Drawing.Point(63, 305);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(305, 75);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_score.Location = new System.Drawing.Point(196, 528);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(39, 29);
            this.label_score.TabIndex = 6;
            this.label_score.Text = "00";
            // 
            // textBox_numberOfWords
            // 
            this.textBox_numberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_numberOfWords.Location = new System.Drawing.Point(63, 485);
            this.textBox_numberOfWords.Name = "textBox_numberOfWords";
            this.textBox_numberOfWords.Size = new System.Drawing.Size(100, 35);
            this.textBox_numberOfWords.TabIndex = 7;
            // 
            // button_setNumberOfWords
            // 
            this.button_setNumberOfWords.BackColor = System.Drawing.Color.PowderBlue;
            this.button_setNumberOfWords.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_setNumberOfWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_setNumberOfWords.Location = new System.Drawing.Point(169, 480);
            this.button_setNumberOfWords.Name = "button_setNumberOfWords";
            this.button_setNumberOfWords.Size = new System.Drawing.Size(199, 45);
            this.button_setNumberOfWords.TabIndex = 8;
            this.button_setNumberOfWords.Text = "Set Number";
            this.button_setNumberOfWords.UseVisualStyleBackColor = false;
            this.button_setNumberOfWords.Click += new System.EventHandler(this.button_setNumberOfWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 579);
            this.Controls.Add(this.button_setNumberOfWords);
            this.Controls.Add(this.textBox_numberOfWords);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label_word);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

