namespace SajalVaiProject
{
    partial class OrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_order_list = new System.Windows.Forms.DataGridView();
            this.o_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_c_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_about = new System.Windows.Forms.DataGridViewButtonColumn();
            this.o_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_o_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_order_list
            // 
            this.dgv_order_list.AllowUserToAddRows = false;
            this.dgv_order_list.AllowUserToDeleteRows = false;
            this.dgv_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.o_id,
            this.o_c_phone,
            this.o_title,
            this.o_type,
            this.o_about,
            this.o_date,
            this.o_delivery,
            this.o_price,
            this.o_advance});
            this.dgv_order_list.Location = new System.Drawing.Point(3, 56);
            this.dgv_order_list.Name = "dgv_order_list";
            this.dgv_order_list.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order_list.Size = new System.Drawing.Size(785, 355);
            this.dgv_order_list.TabIndex = 0;
            this.dgv_order_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_list_CellClick);
            this.dgv_order_list.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_order_list_CellMouseDoubleClick);
            // 
            // o_id
            // 
            this.o_id.HeaderText = "Order Id";
            this.o_id.Name = "o_id";
            this.o_id.ReadOnly = true;
            this.o_id.Width = 89;
            // 
            // o_c_phone
            // 
            this.o_c_phone.HeaderText = "Client Phone";
            this.o_c_phone.Name = "o_c_phone";
            this.o_c_phone.ReadOnly = true;
            this.o_c_phone.Width = 117;
            // 
            // o_title
            // 
            this.o_title.HeaderText = "Title";
            this.o_title.Name = "o_title";
            this.o_title.ReadOnly = true;
            this.o_title.Width = 63;
            // 
            // o_type
            // 
            this.o_type.HeaderText = "Type";
            this.o_type.Name = "o_type";
            this.o_type.ReadOnly = true;
            this.o_type.Width = 65;
            // 
            // o_about
            // 
            this.o_about.HeaderText = "Description";
            this.o_about.Name = "o_about";
            this.o_about.ReadOnly = true;
            this.o_about.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.o_about.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.o_about.ToolTipText = "Click to read and write description";
            this.o_about.Width = 110;
            // 
            // o_date
            // 
            this.o_date.HeaderText = "Order Date";
            this.o_date.Name = "o_date";
            this.o_date.ReadOnly = true;
            this.o_date.Width = 108;
            // 
            // o_delivery
            // 
            this.o_delivery.HeaderText = "Delivery Date";
            this.o_delivery.Name = "o_delivery";
            this.o_delivery.ReadOnly = true;
            this.o_delivery.Width = 124;
            // 
            // o_price
            // 
            this.o_price.HeaderText = "Price";
            this.o_price.Name = "o_price";
            this.o_price.ReadOnly = true;
            this.o_price.Width = 66;
            // 
            // o_advance
            // 
            this.o_advance.HeaderText = "Advanced Paid";
            this.o_advance.Name = "o_advance";
            this.o_advance.ReadOnly = true;
            this.o_advance.Width = 132;
            // 
            // btn_o_edit
            // 
            this.btn_o_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btn_o_edit.Enabled = false;
            this.btn_o_edit.FlatAppearance.BorderSize = 0;
            this.btn_o_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_o_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_o_edit.Location = new System.Drawing.Point(351, 427);
            this.btn_o_edit.Name = "btn_o_edit";
            this.btn_o_edit.Size = new System.Drawing.Size(75, 29);
            this.btn_o_edit.TabIndex = 1;
            this.btn_o_edit.Text = "Edit";
            this.btn_o_edit.UseVisualStyleBackColor = false;
            this.btn_o_edit.Click += new System.EventHandler(this.btn_o_edit_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_o_edit);
            this.Controls.Add(this.dgv_order_list);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(791, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_order_list;
        private System.Windows.Forms.Button btn_o_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_c_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_type;
        private System.Windows.Forms.DataGridViewButtonColumn o_about;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_advance;
    }
}
