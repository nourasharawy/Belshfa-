namespace ya_rab
{
    partial class show_or
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
            this.dgv_master = new System.Windows.Forms.DataGridView();
            this.save_change_btn = new System.Windows.Forms.Button();
            this.Open_mail_btn = new System.Windows.Forms.Button();
            this.dgv_child = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delivery_btn = new System.Windows.Forms.Button();
            this.Pa_email_txt = new System.Windows.Forms.TextBox();
            this.confimarion = new System.Windows.Forms.Button();
            this.Dlivery_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_child)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_master
            // 
            this.dgv_master.AllowUserToAddRows = false;
            this.dgv_master.AllowUserToDeleteRows = false;
            this.dgv_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_master.Location = new System.Drawing.Point(12, 33);
            this.dgv_master.Name = "dgv_master";
            this.dgv_master.Size = new System.Drawing.Size(564, 150);
            this.dgv_master.TabIndex = 0;
            this.dgv_master.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_master_CellClick);
            // 
            // save_change_btn
            // 
            this.save_change_btn.Location = new System.Drawing.Point(145, 383);
            this.save_change_btn.Name = "save_change_btn";
            this.save_change_btn.Size = new System.Drawing.Size(182, 23);
            this.save_change_btn.TabIndex = 1;
            this.save_change_btn.Text = "Save Chages";
            this.save_change_btn.UseVisualStyleBackColor = true;
            this.save_change_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Open_mail_btn
            // 
            this.Open_mail_btn.Location = new System.Drawing.Point(714, 270);
            this.Open_mail_btn.Name = "Open_mail_btn";
            this.Open_mail_btn.Size = new System.Drawing.Size(182, 23);
            this.Open_mail_btn.TabIndex = 2;
            this.Open_mail_btn.Text = "Open  Email";
            this.Open_mail_btn.UseVisualStyleBackColor = true;
            this.Open_mail_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_child
            // 
            this.dgv_child.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_child.Location = new System.Drawing.Point(12, 215);
            this.dgv_child.Name = "dgv_child";
            this.dgv_child.Size = new System.Drawing.Size(315, 150);
            this.dgv_child.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // pro_name_txt
            // 
            this.pro_name_txt.Location = new System.Drawing.Point(554, 273);
            this.pro_name_txt.Name = "pro_name_txt";
            this.pro_name_txt.Size = new System.Drawing.Size(100, 20);
            this.pro_name_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dilevry Email";
            // 
            // Delivery_btn
            // 
            this.Delivery_btn.Location = new System.Drawing.Point(714, 342);
            this.Delivery_btn.Name = "Delivery_btn";
            this.Delivery_btn.Size = new System.Drawing.Size(182, 23);
            this.Delivery_btn.TabIndex = 7;
            this.Delivery_btn.Text = "Sent to  Delivery stock";
            this.Delivery_btn.UseVisualStyleBackColor = true;
            this.Delivery_btn.Click += new System.EventHandler(this.Delivery_btn_Click);
            // 
            // Pa_email_txt
            // 
            this.Pa_email_txt.Location = new System.Drawing.Point(554, 407);
            this.Pa_email_txt.Name = "Pa_email_txt";
            this.Pa_email_txt.Size = new System.Drawing.Size(100, 20);
            this.Pa_email_txt.TabIndex = 8;
            // 
            // confimarion
            // 
            this.confimarion.Location = new System.Drawing.Point(714, 412);
            this.confimarion.Name = "confimarion";
            this.confimarion.Size = new System.Drawing.Size(182, 23);
            this.confimarion.TabIndex = 9;
            this.confimarion.Text = "Send Confirm To User";
            this.confimarion.UseVisualStyleBackColor = true;
            this.confimarion.Click += new System.EventHandler(this.confimarion_Click);
            // 
            // Dlivery_Email
            // 
            this.Dlivery_Email.Location = new System.Drawing.Point(554, 344);
            this.Dlivery_Email.Name = "Dlivery_Email";
            this.Dlivery_Email.Size = new System.Drawing.Size(100, 20);
            this.Dlivery_Email.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient Email";
            // 
            // show_or
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 484);
            this.Controls.Add(this.Dlivery_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confimarion);
            this.Controls.Add(this.Pa_email_txt);
            this.Controls.Add(this.Delivery_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pro_name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_child);
            this.Controls.Add(this.Open_mail_btn);
            this.Controls.Add(this.save_change_btn);
            this.Controls.Add(this.dgv_master);
            this.Name = "show_or";
            this.Text = "show_or";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.show_or_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.show_or_FormClosed);
            this.Load += new System.EventHandler(this.show_or_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_child)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_master;
        private System.Windows.Forms.Button save_change_btn;
        private System.Windows.Forms.Button Open_mail_btn;
        private System.Windows.Forms.DataGridView dgv_child;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pro_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delivery_btn;
        private System.Windows.Forms.TextBox Pa_email_txt;
        private System.Windows.Forms.Button confimarion;
        private System.Windows.Forms.TextBox Dlivery_Email;
        private System.Windows.Forms.Label label3;
    }
}