namespace SajalVaiProject
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnl_manu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_visit = new System.Windows.Forms.Button();
            this.btn_order_list = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_clientList = new System.Windows.Forms.Button();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_winBar = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_manu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_winBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_manu
            // 
            this.pnl_manu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.pnl_manu.Controls.Add(this.pictureBox1);
            this.pnl_manu.Controls.Add(this.btn_select);
            this.pnl_manu.Controls.Add(this.btn_visit);
            this.pnl_manu.Controls.Add(this.btn_order_list);
            this.pnl_manu.Controls.Add(this.btn_addOrder);
            this.pnl_manu.Controls.Add(this.btn_clientList);
            this.pnl_manu.Controls.Add(this.btn_addClient);
            this.pnl_manu.Controls.Add(this.btn_home);
            this.pnl_manu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_manu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_manu.ForeColor = System.Drawing.Color.White;
            this.pnl_manu.Location = new System.Drawing.Point(0, 0);
            this.pnl_manu.Name = "pnl_manu";
            this.pnl_manu.Size = new System.Drawing.Size(217, 541);
            this.pnl_manu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Location = new System.Drawing.Point(1, 144);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(11, 44);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "button7";
            this.btn_select.UseVisualStyleBackColor = false;
            // 
            // btn_visit
            // 
            this.btn_visit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_visit.FlatAppearance.BorderSize = 0;
            this.btn_visit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visit.Image = ((System.Drawing.Image)(resources.GetObject("btn_visit.Image")));
            this.btn_visit.Location = new System.Drawing.Point(11, 394);
            this.btn_visit.Name = "btn_visit";
            this.btn_visit.Size = new System.Drawing.Size(206, 44);
            this.btn_visit.TabIndex = 0;
            this.btn_visit.Text = "Visit ";
            this.btn_visit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_visit.UseVisualStyleBackColor = false;
            this.btn_visit.Click += new System.EventHandler(this.btn_visit_Click);
            // 
            // btn_order_list
            // 
            this.btn_order_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_order_list.FlatAppearance.BorderSize = 0;
            this.btn_order_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_list.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_order_list.Image")));
            this.btn_order_list.Location = new System.Drawing.Point(11, 344);
            this.btn_order_list.Name = "btn_order_list";
            this.btn_order_list.Size = new System.Drawing.Size(206, 44);
            this.btn_order_list.TabIndex = 0;
            this.btn_order_list.Text = "Order List";
            this.btn_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_order_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_order_list.UseVisualStyleBackColor = false;
            this.btn_order_list.Click += new System.EventHandler(this.btn_order_list_Click);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_addOrder.FlatAppearance.BorderSize = 0;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_addOrder.Image")));
            this.btn_addOrder.Location = new System.Drawing.Point(11, 294);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(206, 44);
            this.btn_addOrder.TabIndex = 0;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_clientList
            // 
            this.btn_clientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_clientList.FlatAppearance.BorderSize = 0;
            this.btn_clientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientList.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientList.Image")));
            this.btn_clientList.Location = new System.Drawing.Point(11, 244);
            this.btn_clientList.Name = "btn_clientList";
            this.btn_clientList.Size = new System.Drawing.Size(206, 44);
            this.btn_clientList.TabIndex = 0;
            this.btn_clientList.Text = "Client List";
            this.btn_clientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clientList.UseVisualStyleBackColor = false;
            this.btn_clientList.Click += new System.EventHandler(this.btn_clientList_Click);
            // 
            // btn_addClient
            // 
            this.btn_addClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_addClient.FlatAppearance.BorderSize = 0;
            this.btn_addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClient.Image = ((System.Drawing.Image)(resources.GetObject("btn_addClient.Image")));
            this.btn_addClient.Location = new System.Drawing.Point(11, 194);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(206, 44);
            this.btn_addClient.TabIndex = 0;
            this.btn_addClient.Text = "Add client";
            this.btn_addClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addClient.UseVisualStyleBackColor = false;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(11, 144);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(206, 44);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_winBar
            // 
            this.pnl_winBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.pnl_winBar.Controls.Add(this.btn_close);
            this.pnl_winBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_winBar.ForeColor = System.Drawing.Color.White;
            this.pnl_winBar.Location = new System.Drawing.Point(217, 0);
            this.pnl_winBar.Name = "pnl_winBar";
            this.pnl_winBar.Size = new System.Drawing.Size(791, 58);
            this.pnl_winBar.TabIndex = 1;
            this.pnl_winBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_winBar_MouseDown);
            this.pnl_winBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_winBar_MouseMove);
            this.pnl_winBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_winBar_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Crimson;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.Location = new System.Drawing.Point(728, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 27);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.pnl_winBar);
            this.Controls.Add(this.pnl_manu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_manu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_winBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_manu;
        private System.Windows.Forms.Panel pnl_winBar;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_visit;
        private System.Windows.Forms.Button btn_order_list;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button btn_clientList;
        private System.Windows.Forms.Button btn_addClient;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}