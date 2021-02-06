namespace ya_rab
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
            this.label1 = new System.Windows.Forms.Label();
            this.skip_btn = new System.Windows.Forms.Button();
            this.signin_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(191, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "Belshefa";
            // 
            // skip_btn
            // 
            this.skip_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.skip_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skip_btn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip_btn.ForeColor = System.Drawing.Color.Black;
            this.skip_btn.Location = new System.Drawing.Point(567, 39);
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Size = new System.Drawing.Size(82, 29);
            this.skip_btn.TabIndex = 10;
            this.skip_btn.Text = "skip login ";
            this.skip_btn.UseVisualStyleBackColor = false;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signin_btn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.Black;
            this.signin_btn.Location = new System.Drawing.Point(475, 39);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(86, 29);
            this.signin_btn.TabIndex = 9;
            this.signin_btn.Text = "Sign in ";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_btn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.Black;
            this.Login_btn.Location = new System.Drawing.Point(383, 39);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(86, 29);
            this.Login_btn.TabIndex = 8;
            this.Login_btn.Text = "Login ";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skip_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.Login_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button skip_btn;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button Login_btn;
    }
}

