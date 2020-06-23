namespace demo01
{
    partial class FSignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserNameSignIn = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPasswordSignIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.cbShowPasswordSignIn = new System.Windows.Forms.CheckBox();
            this.btnCancelSignIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelSignIn);
            this.panel1.Controls.Add(this.cbShowPasswordSignIn);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 261);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserNameSignIn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbUserNameSignIn
            // 
            this.txbUserNameSignIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserNameSignIn.Location = new System.Drawing.Point(167, 20);
            this.txbUserNameSignIn.Name = "txbUserNameSignIn";
            this.txbUserNameSignIn.Size = new System.Drawing.Size(335, 28);
            this.txbUserNameSignIn.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPasswordSignIn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 69);
            this.panel3.TabIndex = 1;
            // 
            // txbPasswordSignIn
            // 
            this.txbPasswordSignIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPasswordSignIn.Location = new System.Drawing.Point(167, 20);
            this.txbPasswordSignIn.Name = "txbPasswordSignIn";
            this.txbPasswordSignIn.Size = new System.Drawing.Size(335, 28);
            this.txbPasswordSignIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(89, 199);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(110, 48);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // cbShowPasswordSignIn
            // 
            this.cbShowPasswordSignIn.AutoSize = true;
            this.cbShowPasswordSignIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPasswordSignIn.Location = new System.Drawing.Point(161, 164);
            this.cbShowPasswordSignIn.Name = "cbShowPasswordSignIn";
            this.cbShowPasswordSignIn.Size = new System.Drawing.Size(161, 25);
            this.cbShowPasswordSignIn.TabIndex = 3;
            this.cbShowPasswordSignIn.Text = "Hiển thị mật khẩu";
            this.cbShowPasswordSignIn.UseVisualStyleBackColor = true;
            // 
            // btnCancelSignIn
            // 
            this.btnCancelSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSignIn.Location = new System.Drawing.Point(319, 199);
            this.btnCancelSignIn.Name = "btnCancelSignIn";
            this.btnCancelSignIn.Size = new System.Drawing.Size(110, 48);
            this.btnCancelSignIn.TabIndex = 5;
            this.btnCancelSignIn.Text = "Thoát";
            this.btnCancelSignIn.UseVisualStyleBackColor = true;
            this.btnCancelSignIn.Click += new System.EventHandler(this.btnCancelSignIn_Click);
            // 
            // FSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 267);
            this.Controls.Add(this.panel1);
            this.Name = "FSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSignIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSignIn_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelSignIn;
        private System.Windows.Forms.CheckBox cbShowPasswordSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPasswordSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserNameSignIn;
        private System.Windows.Forms.Label label1;
    }
}