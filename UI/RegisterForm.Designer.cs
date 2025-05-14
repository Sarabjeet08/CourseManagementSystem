namespace CourseManagementSystem
{
    partial class RegisterForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxRuser = new System.Windows.Forms.TextBox();
            this.textBoxRpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRpassConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRback = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 58);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // textBoxRuser
            // 
            this.textBoxRuser.Location = new System.Drawing.Point(154, 52);
            this.textBoxRuser.Name = "textBoxRuser";
            this.textBoxRuser.Size = new System.Drawing.Size(117, 23);
            this.textBoxRuser.TabIndex = 1;
            // 
            // textBoxRpass
            // 
            this.textBoxRpass.Location = new System.Drawing.Point(154, 102);
            this.textBoxRpass.Name = "textBoxRpass";
            this.textBoxRpass.Size = new System.Drawing.Size(117, 23);
            this.textBoxRpass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // textBoxRpassConfirm
            // 
            this.textBoxRpassConfirm.Location = new System.Drawing.Point(154, 152);
            this.textBoxRpassConfirm.Name = "textBoxRpassConfirm";
            this.textBoxRpassConfirm.Size = new System.Drawing.Size(117, 23);
            this.textBoxRpassConfirm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(154, 251);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 26);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonRclear
            // 
            this.buttonRclear.Location = new System.Drawing.Point(26, 251);
            this.buttonRclear.Name = "buttonRclear";
            this.buttonRclear.Size = new System.Drawing.Size(57, 26);
            this.buttonRclear.TabIndex = 7;
            this.buttonRclear.Text = "Clear";
            this.buttonRclear.UseVisualStyleBackColor = true;
            this.buttonRclear.Click += new System.EventHandler(this.buttonRclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Already Have an account";
            // 
            // buttonRback
            // 
            this.buttonRback.Location = new System.Drawing.Point(79, 335);
            this.buttonRback.Name = "buttonRback";
            this.buttonRback.Size = new System.Drawing.Size(117, 27);
            this.buttonRback.TabIndex = 9;
            this.buttonRback.Text = "Click to Login";
            this.buttonRback.UseVisualStyleBackColor = true;
            this.buttonRback.Click += new System.EventHandler(this.buttonRback_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(154, 203);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(117, 24);
            this.comboBoxRole.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Register First!";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRclear);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxRpassConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRuser);
            this.Controls.Add(this.labelUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxRuser;
        private System.Windows.Forms.TextBox textBoxRpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRpassConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label5;
    }
}

