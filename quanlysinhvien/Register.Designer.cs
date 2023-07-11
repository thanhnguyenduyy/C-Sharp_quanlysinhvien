namespace quanlysinhvien
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.button1 = new System.Windows.Forms.Button();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.passworConfirm_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(179, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(227, 163);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_register);
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(179, 218);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(227, 29);
            this.user_txt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(22, 330);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(140, 20);
            this.label111.TabIndex = 18;
            this.label111.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(179, 274);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(227, 29);
            this.password_txt.TabIndex = 20;
            // 
            // passworConfirm_txt
            // 
            this.passworConfirm_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passworConfirm_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworConfirm_txt.Location = new System.Drawing.Point(179, 330);
            this.passworConfirm_txt.Name = "passworConfirm_txt";
            this.passworConfirm_txt.Size = new System.Drawing.Size(227, 29);
            this.passworConfirm_txt.TabIndex = 21;
            // 
            // email_txt
            // 
            this.email_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(179, 387);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(227, 29);
            this.email_txt.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 556);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.passworConfirm_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label111);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Register";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox passworConfirm_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}