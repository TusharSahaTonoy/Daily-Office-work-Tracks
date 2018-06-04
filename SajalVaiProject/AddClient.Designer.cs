namespace SajalVaiProject
{
    partial class AddClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.tb_c_tel = new System.Windows.Forms.TextBox();
            this.tb_c_address = new System.Windows.Forms.TextBox();
            this.tb_c_email = new System.Windows.Forms.TextBox();
            this.tb_c_company = new System.Windows.Forms.TextBox();
            this.tb_c_phone = new System.Windows.Forms.TextBox();
            this.tb_c_name = new System.Windows.Forms.TextBox();
            this.btn_c_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_c_tel
            // 
            this.tb_c_tel.Location = new System.Drawing.Point(201, 352);
            this.tb_c_tel.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_tel.MaxLength = 15;
            this.tb_c_tel.Name = "tb_c_tel";
            this.tb_c_tel.Size = new System.Drawing.Size(472, 27);
            this.tb_c_tel.TabIndex = 5;
            this.tb_c_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_c_tel_KeyPress);
            // 
            // tb_c_address
            // 
            this.tb_c_address.Location = new System.Drawing.Point(201, 287);
            this.tb_c_address.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_address.MaxLength = 100;
            this.tb_c_address.Multiline = true;
            this.tb_c_address.Name = "tb_c_address";
            this.tb_c_address.Size = new System.Drawing.Size(472, 27);
            this.tb_c_address.TabIndex = 4;
            // 
            // tb_c_email
            // 
            this.tb_c_email.Location = new System.Drawing.Point(201, 157);
            this.tb_c_email.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_email.MaxLength = 100;
            this.tb_c_email.Name = "tb_c_email";
            this.tb_c_email.Size = new System.Drawing.Size(472, 27);
            this.tb_c_email.TabIndex = 2;
            // 
            // tb_c_company
            // 
            this.tb_c_company.Location = new System.Drawing.Point(201, 222);
            this.tb_c_company.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_company.MaxLength = 100;
            this.tb_c_company.Multiline = true;
            this.tb_c_company.Name = "tb_c_company";
            this.tb_c_company.Size = new System.Drawing.Size(472, 27);
            this.tb_c_company.TabIndex = 3;
            // 
            // tb_c_phone
            // 
            this.tb_c_phone.Location = new System.Drawing.Point(201, 92);
            this.tb_c_phone.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_phone.MaxLength = 15;
            this.tb_c_phone.Name = "tb_c_phone";
            this.tb_c_phone.Size = new System.Drawing.Size(472, 27);
            this.tb_c_phone.TabIndex = 1;
            this.tb_c_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_c_phone_KeyPress);
            // 
            // tb_c_name
            // 
            this.tb_c_name.Location = new System.Drawing.Point(201, 27);
            this.tb_c_name.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tb_c_name.MaxLength = 50;
            this.tb_c_name.Name = "tb_c_name";
            this.tb_c_name.Size = new System.Drawing.Size(472, 27);
            this.tb_c_name.TabIndex = 0;
            // 
            // btn_c_save
            // 
            this.btn_c_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btn_c_save.FlatAppearance.BorderSize = 0;
            this.btn_c_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_c_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_c_save.Image")));
            this.btn_c_save.Location = new System.Drawing.Point(326, 414);
            this.btn_c_save.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn_c_save.Name = "btn_c_save";
            this.btn_c_save.Size = new System.Drawing.Size(128, 37);
            this.btn_c_save.TabIndex = 6;
            this.btn_c_save.Text = "Save Client";
            this.btn_c_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_c_save.UseVisualStyleBackColor = false;
            this.btn_c_save.Click += new System.EventHandler(this.btn_c_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(93, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(42, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Company Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Business Phone No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(125, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(55, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Client Name :";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tb_c_tel);
            this.Controls.Add(this.tb_c_address);
            this.Controls.Add(this.tb_c_email);
            this.Controls.Add(this.tb_c_company);
            this.Controls.Add(this.tb_c_phone);
            this.Controls.Add(this.tb_c_name);
            this.Controls.Add(this.btn_c_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(791, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_c_tel;
        private System.Windows.Forms.TextBox tb_c_address;
        private System.Windows.Forms.TextBox tb_c_email;
        private System.Windows.Forms.TextBox tb_c_company;
        private System.Windows.Forms.TextBox tb_c_phone;
        private System.Windows.Forms.TextBox tb_c_name;
        private System.Windows.Forms.Button btn_c_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
