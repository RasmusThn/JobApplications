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
            button_search = new Button();
            label_company = new Label();
            textBox_search_company = new TextBox();
            richTextBox1 = new RichTextBox();
            button_create = new Button();
            textBox_jobType = new TextBox();
            label_jobType = new Label();
            button_searchAll = new Button();
            button_edit = new Button();
            listView1 = new ListView();
            columnID = new ColumnHeader();
            columnCompany = new ColumnHeader();
            columnJobType = new ColumnHeader();
            columnLocation = new ColumnHeader();
            columnApplyDate = new ColumnHeader();
            columnResponseDate = new ColumnHeader();
            columnAccepted = new ColumnHeader();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.Location = new Point(226, 134);
            button_search.Name = "button_search";
            button_search.Size = new Size(87, 23);
            button_search.TabIndex = 0;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += buttonSearch_Click;
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
            richTextBox1.Location = new Point(374, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(147, 93);
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
            button_create.Click += buttonCreateJob_Click;
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnID, columnCompany, columnJobType, columnLocation, columnApplyDate, columnResponseDate, columnAccepted });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 289);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(606, 284);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnID
            // 
            columnID.Text = "Id";
            columnID.Width = 30;
            // 
            // columnCompany
            // 
            columnCompany.Text = "Company";
            columnCompany.Width = 100;
            // 
            // columnJobType
            // 
            columnJobType.Text = "JobType";
            columnJobType.Width = 100;
            // 
            // columnLocation
            // 
            columnLocation.Text = "Location";
            columnLocation.Width = 100;
            // 
            // columnApplyDate
            // 
            columnApplyDate.Text = "Apply Date";
            columnApplyDate.Width = 100;
            // 
            // columnResponseDate
            // 
            columnResponseDate.Text = "Response Date";
            columnResponseDate.Width = 100;
            // 
            // columnAccepted
            // 
            columnAccepted.Text = "Accepted";
            columnAccepted.Width = 70;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 585);
            Controls.Add(listView1);
            Controls.Add(button_edit);
            Controls.Add(textBox_jobType);
            Controls.Add(label_jobType);
            Controls.Add(button_searchAll);
            Controls.Add(button_create);
            Controls.Add(richTextBox1);
            Controls.Add(textBox_search_company);
            Controls.Add(label_company);
            Controls.Add(button_search);
            Name = "MainForm";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Label label_company;
        private TextBox textBox_search_company;
        private RichTextBox richTextBox1;
        private Button button_create;
        private TextBox textBox_jobType;
        private Label label_jobType;
        private Button button_searchAll;
        private Button button_edit;
        private ListView listView1;
        private ColumnHeader columnID;
        private ColumnHeader columnCompany;
        private ColumnHeader columnJobType;
        private ColumnHeader columnLocation;
        private ColumnHeader columnApplyDate;
        private ColumnHeader columnResponseDate;
        private ColumnHeader columnAccepted;
    }
}