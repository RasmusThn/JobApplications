namespace JobApplications.Forms
{
    partial class EditJobForm
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
            labelDate = new Label();
            labelLocation = new Label();
            labelJobTitle = new Label();
            labelCompany = new Label();
            button_update = new Button();
            dateTimePicker_apply = new DateTimePicker();
            textBox_location = new TextBox();
            textBox_Job_Type = new TextBox();
            textBox_company = new TextBox();
            labelResponse = new Label();
            dateTimePicker_response = new DateTimePicker();
            checkBox_accepted = new CheckBox();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(113, 181);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(65, 15);
            labelDate.TabIndex = 17;
            labelDate.Text = "Apply Date";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(113, 125);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(53, 15);
            labelLocation.TabIndex = 16;
            labelLocation.Text = "Location";
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(113, 78);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(50, 15);
            labelJobTitle.TabIndex = 15;
            labelJobTitle.Text = "Job Title";
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Location = new Point(113, 33);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(59, 15);
            labelCompany.TabIndex = 14;
            labelCompany.Text = "Company";
            // 
            // button_update
            // 
            button_update.Location = new Point(129, 316);
            button_update.Name = "button_update";
            button_update.Size = new Size(90, 23);
            button_update.TabIndex = 13;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // dateTimePicker_apply
            // 
            dateTimePicker_apply.Location = new Point(113, 199);
            dateTimePicker_apply.Name = "dateTimePicker_apply";
            dateTimePicker_apply.Size = new Size(126, 23);
            dateTimePicker_apply.TabIndex = 12;
            // 
            // textBox_location
            // 
            textBox_location.Location = new Point(113, 143);
            textBox_location.Name = "textBox_location";
            textBox_location.PlaceholderText = "Gothenburg";
            textBox_location.Size = new Size(126, 23);
            textBox_location.TabIndex = 11;
            // 
            // textBox_Job_Type
            // 
            textBox_Job_Type.Location = new Point(113, 96);
            textBox_Job_Type.Name = "textBox_Job_Type";
            textBox_Job_Type.PlaceholderText = "System Engineer";
            textBox_Job_Type.Size = new Size(126, 23);
            textBox_Job_Type.TabIndex = 10;
            // 
            // textBox_company
            // 
            textBox_company.Location = new Point(113, 51);
            textBox_company.Name = "textBox_company";
            textBox_company.PlaceholderText = "Google";
            textBox_company.Size = new Size(126, 23);
            textBox_company.TabIndex = 9;
            // 
            // labelResponse
            // 
            labelResponse.AutoSize = true;
            labelResponse.Location = new Point(113, 225);
            labelResponse.Name = "labelResponse";
            labelResponse.Size = new Size(84, 15);
            labelResponse.TabIndex = 19;
            labelResponse.Text = "Response Date";
            // 
            // dateTimePicker_response
            // 
            dateTimePicker_response.Location = new Point(113, 243);
            dateTimePicker_response.Name = "dateTimePicker_response";
            dateTimePicker_response.Size = new Size(126, 23);
            dateTimePicker_response.TabIndex = 18;
            // 
            // checkBox_accepted
            // 
            checkBox_accepted.AutoSize = true;
            checkBox_accepted.Location = new Point(143, 272);
            checkBox_accepted.Name = "checkBox_accepted";
            checkBox_accepted.Size = new Size(76, 19);
            checkBox_accepted.TabIndex = 20;
            checkBox_accepted.Text = "Accepted";
            checkBox_accepted.UseVisualStyleBackColor = true;
            // 
            // EditJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 380);
            Controls.Add(checkBox_accepted);
            Controls.Add(labelResponse);
            Controls.Add(dateTimePicker_response);
            Controls.Add(labelDate);
            Controls.Add(labelLocation);
            Controls.Add(labelJobTitle);
            Controls.Add(labelCompany);
            Controls.Add(button_update);
            Controls.Add(dateTimePicker_apply);
            Controls.Add(textBox_location);
            Controls.Add(textBox_Job_Type);
            Controls.Add(textBox_company);
            Name = "EditJobForm";
            Text = "EditJobForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelLocation;
        private Label labelJobTitle;
        private Label labelCompany;
        private Button button_update;
        private DateTimePicker dateTimePicker_apply;
        private TextBox textBox_location;
        private TextBox textBox_Job_Type;
        private TextBox textBox_company;
        private Label labelResponse;
        private DateTimePicker dateTimePicker_response;
        private CheckBox checkBox_accepted;
    }
}