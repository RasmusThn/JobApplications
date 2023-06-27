namespace JobApplications
{
    partial class MainForm
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
            button1 = new Button();
            label_company = new Label();
            textBox_search_company = new TextBox();
            richTextBox1 = new RichTextBox();
            button_create = new Button();
            textBox_jobType = new TextBox();
            label_jobType = new Label();
            button_searchAll = new Button();
            button_edit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(226, 134);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_company
            // 
            label_company.AutoSize = true;
            label_company.Location = new Point(41, 25);
            label_company.Name = "label_company";
            label_company.Size = new Size(59, 15);
            label_company.TabIndex = 1;
            label_company.Text = "Company";
            // 
            // textBox_search_company
            // 
            textBox_search_company.Location = new Point(41, 43);
            textBox_search_company.Name = "textBox_search_company";
            textBox_search_company.Size = new Size(100, 23);
            textBox_search_company.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(41, 291);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(443, 282);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button_create
            // 
            button_create.Location = new Point(226, 192);
            button_create.Name = "button_create";
            button_create.Size = new Size(87, 23);
            button_create.TabIndex = 5;
            button_create.Text = "Create New";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button2_Click;
            // 
            // textBox_jobType
            // 
            textBox_jobType.Location = new Point(41, 98);
            textBox_jobType.Name = "textBox_jobType";
            textBox_jobType.Size = new Size(100, 23);
            textBox_jobType.TabIndex = 8;
            // 
            // label_jobType
            // 
            label_jobType.AutoSize = true;
            label_jobType.Location = new Point(41, 80);
            label_jobType.Name = "label_jobType";
            label_jobType.Size = new Size(52, 15);
            label_jobType.TabIndex = 7;
            label_jobType.Text = "Job Type";
            // 
            // button_searchAll
            // 
            button_searchAll.Location = new Point(226, 163);
            button_searchAll.Name = "button_searchAll";
            button_searchAll.Size = new Size(87, 23);
            button_searchAll.TabIndex = 6;
            button_searchAll.Text = "Show All";
            button_searchAll.UseVisualStyleBackColor = true;
            button_searchAll.Click += button_searchAll_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(226, 221);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(87, 23);
            button_edit.TabIndex = 9;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 585);
            Controls.Add(button_edit);
            Controls.Add(textBox_jobType);
            Controls.Add(label_jobType);
            Controls.Add(button_searchAll);
            Controls.Add(button_create);
            Controls.Add(richTextBox1);
            Controls.Add(textBox_search_company);
            Controls.Add(label_company);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_company;
        private TextBox textBox_search_company;
        private RichTextBox richTextBox1;
        private Button button_create;
        private TextBox textBox_jobType;
        private Label label_jobType;
        private Button button_searchAll;
        private Button button_edit;
    }
}