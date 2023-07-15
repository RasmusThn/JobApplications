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
            label_company = new Label();
            textBox_search_company = new TextBox();
            button_create = new Button();
            textBox_jobTitle = new TextBox();
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
            labelHello = new Label();
            textBoxLocation = new TextBox();
            labelLocation = new Label();
            SuspendLayout();
            // 
            // label_company
            // 
            label_company.AutoSize = true;
            label_company.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_company.Location = new Point(196, 73);
            label_company.Name = "label_company";
            label_company.Size = new Size(58, 13);
            label_company.TabIndex = 1;
            label_company.Text = "Company:";
            // 
            // textBox_search_company
            // 
            textBox_search_company.Location = new Point(258, 69);
            textBox_search_company.Name = "textBox_search_company";
            textBox_search_company.PlaceholderText = "All";
            textBox_search_company.Size = new Size(100, 23);
            textBox_search_company.TabIndex = 2;
            // 
            // button_create
            // 
            button_create.Location = new Point(265, 194);
            button_create.Name = "button_create";
            button_create.Size = new Size(87, 23);
            button_create.TabIndex = 6;
            button_create.Text = "Create New";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += buttonCreateJob_Click;
            // 
            // textBox_jobTitle
            // 
            textBox_jobTitle.Location = new Point(258, 98);
            textBox_jobTitle.Name = "textBox_jobTitle";
            textBox_jobTitle.PlaceholderText = "All";
            textBox_jobTitle.Size = new Size(100, 23);
            textBox_jobTitle.TabIndex = 3;
            // 
            // label_jobType
            // 
            label_jobType.AutoSize = true;
            label_jobType.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_jobType.Location = new Point(196, 102);
            label_jobType.Name = "label_jobType";
            label_jobType.Size = new Size(53, 13);
            label_jobType.TabIndex = 7;
            label_jobType.Text = "Job Title:";
            // 
            // button_searchAll
            // 
            button_searchAll.Location = new Point(265, 165);
            button_searchAll.Name = "button_searchAll";
            button_searchAll.Size = new Size(87, 23);
            button_searchAll.TabIndex = 5;
            button_searchAll.Text = "Search";
            button_searchAll.UseVisualStyleBackColor = true;
            button_searchAll.Click += button_searchAll_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(265, 223);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(87, 23);
            button_edit.TabIndex = 7;
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
            columnJobType.Text = "Job Title";
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
            columnResponseDate.Text = "Response";
            columnResponseDate.Width = 100;
            // 
            // columnAccepted
            // 
            columnAccepted.Text = "Interview";
            columnAccepted.Width = 70;
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Location = new Point(31, 27);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(35, 15);
            labelHello.TabIndex = 11;
            labelHello.Text = "Hello";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(258, 130);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.PlaceholderText = "All";
            textBoxLocation.Size = new Size(100, 23);
            textBoxLocation.TabIndex = 4;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocation.Location = new Point(196, 134);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(54, 13);
            labelLocation.TabIndex = 12;
            labelLocation.Text = "Location:";
            labelLocation.Click += labelLocation_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 585);
            Controls.Add(textBoxLocation);
            Controls.Add(labelLocation);
            Controls.Add(labelHello);
            Controls.Add(listView1);
            Controls.Add(button_edit);
            Controls.Add(textBox_jobTitle);
            Controls.Add(label_jobType);
            Controls.Add(button_searchAll);
            Controls.Add(button_create);
            Controls.Add(textBox_search_company);
            Controls.Add(label_company);
            Name = "MainForm";
            Text = "User";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_company;
        private TextBox textBox_search_company;
        private Button button_create;
        private TextBox textBox_jobTitle;
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
        private Label labelHello;
        private TextBox textBoxLocation;
        private Label labelLocation;
    }
}