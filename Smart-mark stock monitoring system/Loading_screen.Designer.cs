namespace Smart_mark_stock_monitoring_system
{
    partial class Loading_screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.splashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "loading";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splashScreen
            // 
            this.splashScreen.Enabled = true;
            this.splashScreen.Interval = 10;
            this.splashScreen.Tick += new System.EventHandler(this.splashScreen_Tick);
            // 
            // Loading_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 327);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(250, 366);
            this.MinimumSize = new System.Drawing.Size(250, 366);
            this.Name = "Loading_screen";
            this.Text = "Smart-Mart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer splashScreen;
    }
}

