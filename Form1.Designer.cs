namespace Barangay_Employee_Management_System
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
            login_btn = new Button();
            username_txtbox = new TextBox();
            password_txtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.Location = new Point(100, 228);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(100, 125);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(178, 27);
            username_txtbox.TabIndex = 1;
            // 
            // password_txtbox
            // 
            password_txtbox.Location = new Point(100, 186);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.Size = new Size(178, 27);
            password_txtbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 102);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 163);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 370);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(login_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private TextBox username_txtbox;
        private TextBox password_txtbox;
        private Label label1;
        private Label label2;
    }
}
