namespace ya_rab
{
    partial class buy
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
            this.label5 = new System.Windows.Forms.Label();
            this.pha_mail_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.M_name = new System.Windows.Forms.TextBox();
            this.Phamacy_un = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.pa_UN_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_now_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data";
            this.label5.Visible = false;
            // 
            // pha_mail_txt
            // 
            this.pha_mail_txt.Location = new System.Drawing.Point(338, 176);
            this.pha_mail_txt.Name = "pha_mail_txt";
            this.pha_mail_txt.Size = new System.Drawing.Size(100, 20);
            this.pha_mail_txt.TabIndex = 28;
            this.pha_mail_txt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Request Sent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // M_name
            // 
            this.M_name.Location = new System.Drawing.Point(190, 145);
            this.M_name.Multiline = true;
            this.M_name.Name = "M_name";
            this.M_name.Size = new System.Drawing.Size(100, 20);
            this.M_name.TabIndex = 26;
            // 
            // Phamacy_un
            // 
            this.Phamacy_un.Location = new System.Drawing.Point(190, 95);
            this.Phamacy_un.Name = "Phamacy_un";
            this.Phamacy_un.Size = new System.Drawing.Size(100, 20);
            this.Phamacy_un.TabIndex = 25;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(190, 56);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(100, 20);
            this.Email_txt.TabIndex = 24;
            // 
            // pa_UN_txt
            // 
            this.pa_UN_txt.Location = new System.Drawing.Point(190, 13);
            this.pa_UN_txt.Name = "pa_UN_txt";
            this.pa_UN_txt.Size = new System.Drawing.Size(100, 20);
            this.pa_UN_txt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "M_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pharmacy_un";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "pharmacy_E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient User Name";
            // 
            // date_now_lbl
            // 
            this.date_now_lbl.AutoSize = true;
            this.date_now_lbl.Location = new System.Drawing.Point(214, 183);
            this.date_now_lbl.Name = "date_now_lbl";
            this.date_now_lbl.Size = new System.Drawing.Size(35, 13);
            this.date_now_lbl.TabIndex = 30;
            this.date_now_lbl.Text = "label6";
            this.date_now_lbl.Click += new System.EventHandler(this.date_now_lbl_Click);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 319);
            this.Controls.Add(this.date_now_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pha_mail_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.M_name);
            this.Controls.Add(this.Phamacy_un);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.pa_UN_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buy";
            this.Text = "buy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buy_FormClosed);
            this.Load += new System.EventHandler(this.buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pha_mail_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox M_name;
        private System.Windows.Forms.TextBox Phamacy_un;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox pa_UN_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date_now_lbl;
    }
}