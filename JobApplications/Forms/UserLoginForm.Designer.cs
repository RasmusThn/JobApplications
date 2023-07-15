namespace JobApplications
{
    partial class UserLoginForm
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
            textBox_user = new TextBox();
            button_login = new Button();
            button_create = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // textBox_user
            // 
            textBox_user.Location = new Point(123, 86);
            textBox_user.Name = "textBox_user";
            textBox_user.PlaceholderText = "User";
            textBox_user.Size = new Size(120, 23);
            textBox_user.TabIndex = 0;
            // 
            // button_login
            // 
            button_login.Location = new Point(123, 157);
            button_login.Name = "button_login";
            button_login.Size = new Size(120, 35);
            button_login.TabIndex = 1;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_create
            // 
            button_create.Location = new Point(123, 198);
            button_create.Name = "button_create";
            button_create.Size = new Size(120, 35);
            button_create.TabIndex = 2;
            button_create.Text = "Create New User";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(123, 112);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "label1";
            errorLabel.Visible = false;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 385);
            Controls.Add(errorLabel);
            Controls.Add(button_create);
            Controls.Add(button_login);
            Controls.Add(textBox_user);
            Name = "UserLoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_user;
        private Button button_login;
        private Button button_create;
        private Label errorLabel;
    }
}