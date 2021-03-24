namespace mineSweeperGUI
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_grid
            // 
            this.pnl_grid.Location = new System.Drawing.Point(13, 35);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(500, 500);
            this.pnl_grid.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(13, 12);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(40, 17);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "0:0:0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 547);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pnl_grid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
    }
}