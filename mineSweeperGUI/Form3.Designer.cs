namespace mineSweeperGUI
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lb_scores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 5 HIGH SCORES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "LEVEL:";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(74, 36);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(0, 17);
            this.lbl_level.TabIndex = 2;
            // 
            // lb_scores
            // 
            this.lb_scores.FormattingEnabled = true;
            this.lb_scores.ItemHeight = 16;
            this.lb_scores.Location = new System.Drawing.Point(15, 73);
            this.lb_scores.Name = "lb_scores";
            this.lb_scores.Size = new System.Drawing.Size(467, 164);
            this.lb_scores.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 240);
            this.Controls.Add(this.lb_scores);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.ListBox lb_scores;
    }
}