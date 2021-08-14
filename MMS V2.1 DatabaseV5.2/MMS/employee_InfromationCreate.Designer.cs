
namespace MMS
{
    partial class employee_InfromationCreate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_yes = new System.Windows.Forms.RadioButton();
            this.rad_No = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.txt_EmpPassword = new System.Windows.Forms.TextBox();
            this.txt_EmpSalary = new System.Windows.Forms.TextBox();
            this.txt_AssignedShop = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Emp_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(108, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "Create Employee Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMS.Properties.Resources.emp;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Employee Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Employee Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(527, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Is this employee is any shop manager? ";
            // 
            // rad_yes
            // 
            this.rad_yes.AutoSize = true;
            this.rad_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_yes.Location = new System.Drawing.Point(584, 580);
            this.rad_yes.Name = "rad_yes";
            this.rad_yes.Size = new System.Drawing.Size(89, 29);
            this.rad_yes.TabIndex = 22;
            this.rad_yes.TabStop = true;
            this.rad_yes.Text = "YES";
            this.rad_yes.UseVisualStyleBackColor = true;
            // 
            // rad_No
            // 
            this.rad_No.AutoSize = true;
            this.rad_No.BackColor = System.Drawing.Color.Transparent;
            this.rad_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_No.Location = new System.Drawing.Point(695, 580);
            this.rad_No.Name = "rad_No";
            this.rad_No.Size = new System.Drawing.Size(72, 29);
            this.rad_No.TabIndex = 23;
            this.rad_No.TabStop = true;
            this.rad_No.Text = "No";
            this.rad_No.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Employee assigned shop ID: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Employee Name:";
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(339, 299);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(405, 31);
            this.txt_EmpName.TabIndex = 26;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(339, 357);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(405, 31);
            this.txt_EmpID.TabIndex = 27;
            // 
            // txt_EmpPassword
            // 
            this.txt_EmpPassword.Location = new System.Drawing.Point(339, 408);
            this.txt_EmpPassword.Name = "txt_EmpPassword";
            this.txt_EmpPassword.Size = new System.Drawing.Size(405, 31);
            this.txt_EmpPassword.TabIndex = 28;
            // 
            // txt_EmpSalary
            // 
            this.txt_EmpSalary.Location = new System.Drawing.Point(339, 466);
            this.txt_EmpSalary.Name = "txt_EmpSalary";
            this.txt_EmpSalary.Size = new System.Drawing.Size(405, 31);
            this.txt_EmpSalary.TabIndex = 29;
            // 
            // txt_AssignedShop
            // 
            this.txt_AssignedShop.Location = new System.Drawing.Point(450, 522);
            this.txt_AssignedShop.Name = "txt_AssignedShop";
            this.txt_AssignedShop.Size = new System.Drawing.Size(294, 31);
            this.txt_AssignedShop.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(339, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 5);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(339, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 5);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(339, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 5);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(339, 503);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 5);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(450, 559);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 5);
            this.panel5.TabIndex = 35;
            // 
            // btn_Emp_Login
            // 
            this.btn_Emp_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Emp_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Emp_Login.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Emp_Login.Location = new System.Drawing.Point(216, 639);
            this.btn_Emp_Login.Name = "btn_Emp_Login";
            this.btn_Emp_Login.Size = new System.Drawing.Size(457, 56);
            this.btn_Emp_Login.TabIndex = 36;
            this.btn_Emp_Login.Text = "Create Account";
            this.btn_Emp_Login.UseVisualStyleBackColor = false;
            this.btn_Emp_Login.Click += new System.EventHandler(this.btn_Emp_Login_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 56);
            this.button1.TabIndex = 37;
            this.button1.Text = "Cancel and Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeAccountCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 831);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Emp_Login);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_AssignedShop);
            this.Controls.Add(this.txt_EmpSalary);
            this.Controls.Add(this.txt_EmpPassword);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rad_No);
            this.Controls.Add(this.rad_yes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeAccountCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Employee Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_yes;
        private System.Windows.Forms.RadioButton rad_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.TextBox txt_EmpPassword;
        private System.Windows.Forms.TextBox txt_EmpSalary;
        private System.Windows.Forms.TextBox txt_AssignedShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Emp_Login;
        private System.Windows.Forms.Button button1;
    }
}