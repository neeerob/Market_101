
namespace MMS
{
    partial class shop_Management
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_changePassword = new System.Windows.Forms.TextBox();
            this.btn_searchShop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_shopID = new System.Windows.Forms.TextBox();
            this.txt_shopName = new System.Windows.Forms.TextBox();
            this.lbl_shopName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 51);
            this.label9.TabIndex = 1;
            this.label9.Text = "101";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 51);
            this.label8.TabIndex = 0;
            this.label8.Text = "Welcome to Market";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_changePassword);
            this.panel1.Controls.Add(this.btn_searchShop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 153);
            this.panel1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Search by shop ID";
            // 
            // txt_changePassword
            // 
            this.txt_changePassword.Location = new System.Drawing.Point(788, 87);
            this.txt_changePassword.Name = "txt_changePassword";
            this.txt_changePassword.Size = new System.Drawing.Size(173, 31);
            this.txt_changePassword.TabIndex = 42;
            // 
            // btn_searchShop
            // 
            this.btn_searchShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_searchShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchShop.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchShop.ForeColor = System.Drawing.Color.Black;
            this.btn_searchShop.Location = new System.Drawing.Point(967, 84);
            this.btn_searchShop.Name = "btn_searchShop";
            this.btn_searchShop.Size = new System.Drawing.Size(101, 40);
            this.btn_searchShop.TabIndex = 41;
            this.btn_searchShop.Text = "Search";
            this.btn_searchShop.UseVisualStyleBackColor = false;
            this.btn_searchShop.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopid,
            this.shopName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 253);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // shopid
            // 
            this.shopid.DataPropertyName = "shopID";
            this.shopid.HeaderText = "Shop ID";
            this.shopid.MinimumWidth = 10;
            this.shopid.Name = "shopid";
            this.shopid.Width = 200;
            // 
            // shopName
            // 
            this.shopName.DataPropertyName = "shopName";
            this.shopName.HeaderText = "Shop Name";
            this.shopName.MinimumWidth = 10;
            this.shopName.Name = "shopName";
            this.shopName.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(757, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 5);
            this.panel2.TabIndex = 102;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(757, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 5);
            this.panel4.TabIndex = 101;
            // 
            // txt_shopID
            // 
            this.txt_shopID.Location = new System.Drawing.Point(757, 255);
            this.txt_shopID.Name = "txt_shopID";
            this.txt_shopID.ReadOnly = true;
            this.txt_shopID.Size = new System.Drawing.Size(313, 31);
            this.txt_shopID.TabIndex = 100;
            // 
            // txt_shopName
            // 
            this.txt_shopName.Location = new System.Drawing.Point(757, 192);
            this.txt_shopName.Name = "txt_shopName";
            this.txt_shopName.Size = new System.Drawing.Size(313, 31);
            this.txt_shopName.TabIndex = 99;
            // 
            // lbl_shopName
            // 
            this.lbl_shopName.AutoSize = true;
            this.lbl_shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shopName.Location = new System.Drawing.Point(563, 195);
            this.lbl_shopName.Name = "lbl_shopName";
            this.lbl_shopName.Size = new System.Drawing.Size(140, 25);
            this.lbl_shopName.TabIndex = 98;
            this.lbl_shopName.Text = "Shop Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(563, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 97;
            this.label11.Text = "Shop ID:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(637, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 61);
            this.button4.TabIndex = 111;
            this.button4.Text = "Update Info";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(848, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 61);
            this.button1.TabIndex = 112;
            this.button1.Text = "Delete Shop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(705, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 61);
            this.button2.TabIndex = 113;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shop_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_shopID);
            this.Controls.Add(this.txt_shopName);
            this.Controls.Add(this.lbl_shopName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "shop_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shop Management";
            this.Load += new System.EventHandler(this.shop_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_searchShop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_changePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_shopID;
        private System.Windows.Forms.TextBox txt_shopName;
        private System.Windows.Forms.Label lbl_shopName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopid;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopName;
        private System.Windows.Forms.Button button2;
    }
}