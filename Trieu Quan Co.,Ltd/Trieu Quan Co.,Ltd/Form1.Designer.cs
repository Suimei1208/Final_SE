namespace Trieu_Quan_Co._Ltd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            login = new Button();
            username = new TextBox();
            password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(383, 40);
            label1.Name = "label1";
            label1.Size = new Size(133, 54);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(170, 138);
            label2.Name = "label2";
            label2.Size = new Size(548, 37);
            label2.TabIndex = 1;
            label2.Text = "The account has been pre-assigned for login.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 216);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 292);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // login
            // 
            login.BackColor = Color.Black;
            login.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = SystemColors.Info;
            login.Location = new Point(626, 378);
            login.Name = "login";
            login.Size = new Size(133, 60);
            login.TabIndex = 4;
            login.Text = "Log in";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // username
            // 
            username.BackColor = SystemColors.Window;
            username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(304, 214);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(318, 40);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(304, 290);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(318, 40);
            password.TabIndex = 6;
            password.KeyPress += password_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(771, 450);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Log in";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button login;
        private TextBox username;
        private TextBox password;
    }
}