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
            SuspendLayout();
            // 
            // textBox_company
            // 
            textBox_company.Location = new Point(217, 107);
            textBox_company.Name = "textBox_company";
            textBox_company.PlaceholderText = "Company Name";
            textBox_company.Size = new Size(126, 23);
            textBox_company.TabIndex = 0;
            // 
            // textBox_Job_Type
            // 
            textBox_Job_Type.Location = new Point(217, 152);
            textBox_Job_Type.Name = "textBox_Job_Type";
            textBox_Job_Type.PlaceholderText = "Job Type";
            textBox_Job_Type.Size = new Size(126, 23);
            textBox_Job_Type.TabIndex = 1;
            // 
            // textBox_location
            // 
            textBox_location.Location = new Point(217, 199);
            textBox_location.Name = "textBox_location";
            textBox_location.PlaceholderText = "Location";
            textBox_location.Size = new Size(126, 23);
            textBox_location.TabIndex = 2;
            // 
            // dateTimePicker_create
            // 
            dateTimePicker_create.Location = new Point(217, 249);
            dateTimePicker_create.Name = "dateTimePicker_create";
            dateTimePicker_create.Size = new Size(126, 23);
            dateTimePicker_create.TabIndex = 3;
            // 
            // button_createJob
            // 
            button_createJob.Location = new Point(217, 311);
            button_createJob.Name = "button_createJob";
            button_createJob.Size = new Size(126, 23);
            button_createJob.TabIndex = 4;
            button_createJob.Text = "Create";
            button_createJob.UseVisualStyleBackColor = true;
            button_createJob.Click += button_createJob_Click;
            // 
            // CreateJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 647);
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
    }
}