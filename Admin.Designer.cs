namespace ya_rab
{
    partial class Admin
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
            this.make_reprot_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_pro_btn = new System.Windows.Forms.Button();
            this.Edit_pro_btn = new System.Windows.Forms.Button();
            this.view_pro_btn = new System.Windows.Forms.Button();
            this.delete_pro_btn = new System.Windows.Forms.Button();
            this.show_order_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // make_reprot_btn
            // 
            this.make_reprot_btn.Location = new System.Drawing.Point(55, 312);
            this.make_reprot_btn.Name = "make_reprot_btn";
            this.make_reprot_btn.Size = new System.Drawing.Size(337, 29);
            this.make_reprot_btn.TabIndex = 0;
            this.make_reprot_btn.Text = "Make Report";
            this.make_reprot_btn.UseVisualStyleBackColor = true;
            this.make_reprot_btn.Click += new System.EventHandler(this.make_reprot_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 12);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_pro_btn
            // 
            this.Add_pro_btn.Location = new System.Drawing.Point(55, 37);
            this.Add_pro_btn.Name = "Add_pro_btn";
            this.Add_pro_btn.Size = new System.Drawing.Size(337, 23);
            this.Add_pro_btn.TabIndex = 6;
            this.Add_pro_btn.Text = "Add Product";
            this.Add_pro_btn.UseVisualStyleBackColor = true;
            this.Add_pro_btn.Click += new System.EventHandler(this.Add_pro_btn_Click);
            // 
            // Edit_pro_btn
            // 
            this.Edit_pro_btn.Location = new System.Drawing.Point(55, 92);
            this.Edit_pro_btn.Name = "Edit_pro_btn";
            this.Edit_pro_btn.Size = new System.Drawing.Size(337, 23);
            this.Edit_pro_btn.TabIndex = 7;
            this.Edit_pro_btn.Text = "Edit Product";
            this.Edit_pro_btn.UseVisualStyleBackColor = true;
            // 
            // view_pro_btn
            // 
            this.view_pro_btn.Location = new System.Drawing.Point(55, 147);
            this.view_pro_btn.Name = "view_pro_btn";
            this.view_pro_btn.Size = new System.Drawing.Size(337, 23);
            this.view_pro_btn.TabIndex = 8;
            this.view_pro_btn.Text = "View Product";
            this.view_pro_btn.UseVisualStyleBackColor = true;
            // 
            // delete_pro_btn
            // 
            this.delete_pro_btn.Location = new System.Drawing.Point(55, 195);
            this.delete_pro_btn.Name = "delete_pro_btn";
            this.delete_pro_btn.Size = new System.Drawing.Size(337, 23);
            this.delete_pro_btn.TabIndex = 9;
            this.delete_pro_btn.Text = "Delete Product";
            this.delete_pro_btn.UseVisualStyleBackColor = true;
            this.delete_pro_btn.Click += new System.EventHandler(this.delete_pro_btn_Click);
            // 
            // show_order_btn
            // 
            this.show_order_btn.Location = new System.Drawing.Point(55, 262);
            this.show_order_btn.Name = "show_order_btn";
            this.show_order_btn.Size = new System.Drawing.Size(337, 23);
            this.show_order_btn.TabIndex = 10;
            this.show_order_btn.Text = "Show Orders";
            this.show_order_btn.UseVisualStyleBackColor = true;
            this.show_order_btn.Click += new System.EventHandler(this.show_order_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show Order Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_order_btn);
            this.Controls.Add(this.delete_pro_btn);
            this.Controls.Add(this.view_pro_btn);
            this.Controls.Add(this.Edit_pro_btn);
            this.Controls.Add(this.Add_pro_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.make_reprot_btn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button make_reprot_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_pro_btn;
        private System.Windows.Forms.Button Edit_pro_btn;
        private System.Windows.Forms.Button view_pro_btn;
        private System.Windows.Forms.Button delete_pro_btn;
        private System.Windows.Forms.Button show_order_btn;
        private System.Windows.Forms.Button button1;
    }
}