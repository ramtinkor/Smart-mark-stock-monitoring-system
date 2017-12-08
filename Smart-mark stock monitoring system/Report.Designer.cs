namespace Smart_mark_stock_monitoring_system
{
    partial class Report
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.lblMb = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(234, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report";
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(50, 145);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(85, 13);
            this.lblReorder.TabIndex = 1;
            this.lblReorder.Text = "Items Reordered";
            // 
            // lblMb
            // 
            this.lblMb.AutoSize = true;
            this.lblMb.Location = new System.Drawing.Point(50, 241);
            this.lblMb.Name = "lblMb";
            this.lblMb.Size = new System.Drawing.Size(67, 13);
            this.lblMb.TabIndex = 2;
            this.lblMb.Text = "Most Bought";
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(50, 325);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(70, 13);
            this.lblLB.TabIndex = 3;
            this.lblLB.Text = "Least Bought";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 498);
            this.Controls.Add(this.lblLB);
            this.Controls.Add(this.lblMb);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.lblTitle);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.Label lblMb;
        private System.Windows.Forms.Label lblLB;
    }
}