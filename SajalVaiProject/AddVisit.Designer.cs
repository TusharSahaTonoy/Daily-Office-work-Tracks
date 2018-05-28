namespace SajalVaiProject
{
    partial class AddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisit));
            this.btn_v_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_v_id = new System.Windows.Forms.Label();
            this.tb_v_company = new System.Windows.Forms.TextBox();
            this.tb_v_type = new System.Windows.Forms.TextBox();
            this.tb_v_visitor = new System.Windows.Forms.TextBox();
            this.tb_v_response = new System.Windows.Forms.TextBox();
            this.dtp_v_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_v_address = new System.Windows.Forms.TextBox();
            this.tb_v_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_v_save
            // 
            this.btn_v_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_v_save.FlatAppearance.BorderSize = 0;
            this.btn_v_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_v_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_v_save.Image")));
            this.btn_v_save.Location = new System.Drawing.Point(619, 223);
            this.btn_v_save.Name = "btn_v_save";
            this.btn_v_save.Size = new System.Drawing.Size(95, 36);
            this.btn_v_save.TabIndex = 0;
            this.btn_v_save.Text = " Save";
            this.btn_v_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_v_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_v_save.UseVisualStyleBackColor = false;
            this.btn_v_save.Click += new System.EventHandler(this.btn_v_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visit Count No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Visit Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Response :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Visitor Name :";
            // 
            // lbl_v_id
            // 
            this.lbl_v_id.AutoSize = true;
            this.lbl_v_id.Location = new System.Drawing.Point(153, 26);
            this.lbl_v_id.Name = "lbl_v_id";
            this.lbl_v_id.Size = new System.Drawing.Size(41, 20);
            this.lbl_v_id.TabIndex = 1;
            this.lbl_v_id.Text = "Auto";
            // 
            // tb_v_company
            // 
            this.tb_v_company.Location = new System.Drawing.Point(153, 70);
            this.tb_v_company.Name = "tb_v_company";
            this.tb_v_company.Size = new System.Drawing.Size(401, 27);
            this.tb_v_company.TabIndex = 4;
            // 
            // tb_v_type
            // 
            this.tb_v_type.Location = new System.Drawing.Point(153, 246);
            this.tb_v_type.Name = "tb_v_type";
            this.tb_v_type.Size = new System.Drawing.Size(401, 27);
            this.tb_v_type.TabIndex = 4;
            // 
            // tb_v_visitor
            // 
            this.tb_v_visitor.Location = new System.Drawing.Point(153, 290);
            this.tb_v_visitor.Name = "tb_v_visitor";
            this.tb_v_visitor.Size = new System.Drawing.Size(401, 27);
            this.tb_v_visitor.TabIndex = 4;
            // 
            // tb_v_response
            // 
            this.tb_v_response.Location = new System.Drawing.Point(153, 334);
            this.tb_v_response.Multiline = true;
            this.tb_v_response.Name = "tb_v_response";
            this.tb_v_response.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_v_response.Size = new System.Drawing.Size(401, 104);
            this.tb_v_response.TabIndex = 4;
            // 
            // dtp_v_date
            // 
            this.dtp_v_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_v_date.Location = new System.Drawing.Point(157, 202);
            this.dtp_v_date.Name = "dtp_v_date";
            this.dtp_v_date.Size = new System.Drawing.Size(118, 27);
            this.dtp_v_date.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Company Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone :";
            // 
            // tb_v_address
            // 
            this.tb_v_address.Location = new System.Drawing.Point(153, 114);
            this.tb_v_address.Name = "tb_v_address";
            this.tb_v_address.Size = new System.Drawing.Size(401, 27);
            this.tb_v_address.TabIndex = 4;
            // 
            // tb_v_phone
            // 
            this.tb_v_phone.Location = new System.Drawing.Point(153, 158);
            this.tb_v_phone.Name = "tb_v_phone";
            this.tb_v_phone.Size = new System.Drawing.Size(401, 27);
            this.tb_v_phone.TabIndex = 4;
            this.tb_v_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_v_phone_KeyPress);
            // 
            // AddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_v_date);
            this.Controls.Add(this.tb_v_response);
            this.Controls.Add(this.tb_v_phone);
            this.Controls.Add(this.tb_v_visitor);
            this.Controls.Add(this.tb_v_type);
            this.Controls.Add(this.tb_v_address);
            this.Controls.Add(this.tb_v_company);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_v_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_v_save);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddVisit";
            this.Size = new System.Drawing.Size(791, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_v_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_v_id;
        private System.Windows.Forms.TextBox tb_v_company;
        private System.Windows.Forms.TextBox tb_v_type;
        private System.Windows.Forms.TextBox tb_v_visitor;
        private System.Windows.Forms.TextBox tb_v_response;
        private System.Windows.Forms.DateTimePicker dtp_v_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_v_address;
        private System.Windows.Forms.TextBox tb_v_phone;
    }
}
