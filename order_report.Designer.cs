namespace ya_rab
{
    partial class order_report
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
            this.Staet_txt = new System.Windows.Forms.TextBox();
            this.End_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // Staet_txt
            // 
            this.Staet_txt.Location = new System.Drawing.Point(156, 25);
            this.Staet_txt.Name = "Staet_txt";
            this.Staet_txt.Size = new System.Drawing.Size(100, 20);
            this.Staet_txt.TabIndex = 2;
            // 
            // End_txt
            // 
            this.End_txt.Location = new System.Drawing.Point(440, 25);
            this.End_txt.Name = "End_txt";
            this.End_txt.Size = new System.Drawing.Size(100, 20);
            this.End_txt.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(650, 23);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 92);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(839, 381);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // order_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.End_txt);
            this.Controls.Add(this.Staet_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "order_report";
            this.Text = "order_report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.order_report_FormClosed);
            this.Load += new System.EventHandler(this.order_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Staet_txt;
        private System.Windows.Forms.TextBox End_txt;
        private System.Windows.Forms.Button Search_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}