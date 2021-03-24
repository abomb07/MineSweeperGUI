namespace mineSweeperGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.rbtn_hard = new System.Windows.Forms.RadioButton();
            this.rbtn_medium = new System.Windows.Forms.RadioButton();
            this.rbtn_easy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start_game);
            this.groupBox1.Controls.Add(this.rbtn_hard);
            this.groupBox1.Controls.Add(this.rbtn_medium);
            this.groupBox1.Controls.Add(this.rbtn_easy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Difficulty";
            // 
            // btn_start_game
            // 
            this.btn_start_game.Location = new System.Drawing.Point(218, 136);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(75, 23);
            this.btn_start_game.TabIndex = 3;
            this.btn_start_game.Text = "Start";
            this.btn_start_game.UseVisualStyleBackColor = true;
            this.btn_start_game.Click += new System.EventHandler(this.btn_start_game_Click);
            // 
            // rbtn_hard
            // 
            this.rbtn_hard.AutoSize = true;
            this.rbtn_hard.Location = new System.Drawing.Point(6, 137);
            this.rbtn_hard.Name = "rbtn_hard";
            this.rbtn_hard.Size = new System.Drawing.Size(60, 21);
            this.rbtn_hard.TabIndex = 2;
            this.rbtn_hard.TabStop = true;
            this.rbtn_hard.Text = "Hard";
            this.rbtn_hard.UseVisualStyleBackColor = true;
            // 
            // rbtn_medium
            // 
            this.rbtn_medium.AutoSize = true;
            this.rbtn_medium.Location = new System.Drawing.Point(6, 88);
            this.rbtn_medium.Name = "rbtn_medium";
            this.rbtn_medium.Size = new System.Drawing.Size(78, 21);
            this.rbtn_medium.TabIndex = 1;
            this.rbtn_medium.TabStop = true;
            this.rbtn_medium.Text = "Medium";
            this.rbtn_medium.UseVisualStyleBackColor = true;
            // 
            // rbtn_easy
            // 
            this.rbtn_easy.AutoSize = true;
            this.rbtn_easy.Location = new System.Drawing.Point(6, 39);
            this.rbtn_easy.Name = "rbtn_easy";
            this.rbtn_easy.Size = new System.Drawing.Size(60, 21);
            this.rbtn_easy.TabIndex = 0;
            this.rbtn_easy.TabStop = true;
            this.rbtn_easy.Text = "Easy";
            this.rbtn_easy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.RadioButton rbtn_hard;
        private System.Windows.Forms.RadioButton rbtn_medium;
        private System.Windows.Forms.RadioButton rbtn_easy;
    }
}