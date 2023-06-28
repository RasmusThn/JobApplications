namespace JobApplications
{
    partial class CreateJobForm
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
            textBox_company = new TextBox();
            textBox_Job_Type = new TextBox();
            textBox_location = new TextBox();
            dateTimePicker_create = new DateTimePicker();
            button_createJob = new Button();
            labelCompany = new Label();
            labelJobTitle = new Label();
            labelLocation = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // textBox_company
            // 
            textBox_company.Location = new Point(119, 75);
            textBox_company.Name = "textBox_company";
            textBox_company.PlaceholderText = "Google";
            textBox_company.Size = new Size(126, 23);
            textBox_company.TabIndex = 0;
            textBox_company.TextChanged += textBox_company_TextChanged;
            // 
            // textBox_Job_Type
            // 
            textBox_Job_Type.Location = new Point(119, 120);
            textBox_Job_Type.Name = "textBox_Job_Type";
            textBox_Job_Type.PlaceholderText = "System Engineer";
            textBox_Job_Type.Size = new Size(126, 23);
            textBox_Job_Type.TabIndex = 1;
            textBox_Job_Type.TextChanged += textBox_Job_Type_TextChanged;
            // 
            // textBox_location
            // 
            textBox_location.Location = new Point(119, 167);
            textBox_location.Name = "textBox_location";
            textBox_location.PlaceholderText = "Gothenburg";
            textBox_location.Size = new Size(126, 23);
            textBox_location.TabIndex = 2;
            textBox_location.TextChanged += textBox_location_TextChanged;
            // 
            // dateTimePicker_create
            // 
            dateTimePicker_create.Location = new Point(119, 217);
            dateTimePicker_create.Name = "dateTimePicker_create";
            dateTimePicker_create.Size = new Size(126, 23);
            dateTimePicker_create.TabIndex = 3;
            dateTimePicker_create.ValueChanged += dateTimePicker_create_ValueChanged;
            // 
            // button_createJob
            // 
            button_createJob.Location = new Point(134, 279);
            button_createJob.Name = "button_createJob";
            button_createJob.Size = new Size(90, 23);
            button_createJob.TabIndex = 4;
            button_createJob.Text = "Add";
            button_createJob.UseVisualStyleBackColor = true;
            button_createJob.Click += button_createJob_Click;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Location = new Point(119, 57);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(59, 15);
            labelCompany.TabIndex = 5;
            labelCompany.Text = "Company";
            labelCompany.Click += labelCompany_Click;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(119, 102);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(50, 15);
            labelJobTitle.TabIndex = 6;
            labelJobTitle.Text = "Job Title";
            labelJobTitle.Click += labelJobTitle_Click;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(119, 149);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(53, 15);
            labelLocation.TabIndex = 7;
            labelLocation.Text = "Location";
            labelLocation.Click += labelLocation_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(119, 199);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(65, 15);
            labelDate.TabIndex = 8;
            labelDate.Text = "Apply Date";
            labelDate.Click += labelDate_Click;
            // 
            // CreateJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 385);
            Controls.Add(labelDate);
            Controls.Add(labelLocation);
            Controls.Add(labelJobTitle);
            Controls.Add(labelCompany);
            Controls.Add(button_createJob);
            Controls.Add(dateTimePicker_create);
            Controls.Add(textBox_location);
            Controls.Add(textBox_Job_Type);
            Controls.Add(textBox_company);
            Name = "CreateJobForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_company;
        private TextBox textBox_Job_Type;
        private TextBox textBox_location;
        private DateTimePicker dateTimePicker_create;
        private Button button_createJob;
        private Label labelCompany;
        private Label labelJobTitle;
        private Label labelLocation;
        private Label labelDate;
    }
}