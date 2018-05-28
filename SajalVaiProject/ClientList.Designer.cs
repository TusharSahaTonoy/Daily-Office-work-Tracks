namespace SajalVaiProject
{
    partial class ClientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.dgv_client_list = new System.Windows.Forms.DataGridView();
            this.btn_client_edit = new System.Windows.Forms.Button();
            this.btn_client_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_client_list
            // 
            this.dgv_client_list.AllowUserToAddRows = false;
            this.dgv_client_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_client_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_client_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_client_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_client_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_client_list.Location = new System.Drawing.Point(30, 58);
            this.dgv_client_list.Name = "dgv_client_list";
            this.dgv_client_list.ReadOnly = true;
            this.dgv_client_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client_list.ShowCellToolTips = false;
            this.dgv_client_list.Size = new System.Drawing.Size(706, 356);
            this.dgv_client_list.TabIndex = 0;
            this.dgv_client_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_client_list_MouseDoubleClick);
            // 
            // btn_client_edit
            // 
            this.btn_client_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btn_client_edit.FlatAppearance.BorderSize = 0;
            this.btn_client_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client_edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_edit.ForeColor = System.Drawing.Color.White;
            this.btn_client_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_client_edit.Image")));
            this.btn_client_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client_edit.Location = new System.Drawing.Point(62, 430);
            this.btn_client_edit.Name = "btn_client_edit";
            this.btn_client_edit.Size = new System.Drawing.Size(86, 31);
            this.btn_client_edit.TabIndex = 1;
            this.btn_client_edit.Text = "Edit";
            this.btn_client_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_client_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_client_edit.UseVisualStyleBackColor = false;
            this.btn_client_edit.Click += new System.EventHandler(this.btn_client_edit_Click);
            // 
            // btn_client_delete
            // 
            this.btn_client_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btn_client_delete.FlatAppearance.BorderSize = 0;
            this.btn_client_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_delete.ForeColor = System.Drawing.Color.White;
            this.btn_client_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_client_delete.Image")));
            this.btn_client_delete.Location = new System.Drawing.Point(212, 430);
            this.btn_client_delete.Name = "btn_client_delete";
            this.btn_client_delete.Size = new System.Drawing.Size(92, 31);
            this.btn_client_delete.TabIndex = 1;
            this.btn_client_delete.Text = "Delete";
            this.btn_client_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_client_delete.UseVisualStyleBackColor = false;
            this.btn_client_delete.Click += new System.EventHandler(this.btn_client_delete_Click);
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_client_delete);
            this.Controls.Add(this.btn_client_edit);
            this.Controls.Add(this.dgv_client_list);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientList";
            this.Size = new System.Drawing.Size(791, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client_list;
        private System.Windows.Forms.Button btn_client_edit;
        private System.Windows.Forms.Button btn_client_delete;
    }
}
