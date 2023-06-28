using Entitys;
using ServiceContracts.Interfaces;

namespace JobApplications
{
    public partial class MainForm : Form
    {
        private User _user;
        private IConnectionStringProvider connectionStringProvider;

        public MainForm(User user)
        {
            InitializeComponent();
            this._user = user;
            this.Text = _user.Name;
            richTextBox1.AppendText("Logged in as: " + _user.Name);
            listView1.ColumnClick += listView1_ColumnClick;
            //SetupListViewColumns();
        }

        public MainForm(User user, IConnectionStringProvider connectionStringProvider) : this(user)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AppendTextToRichBox(textBox_search_company.Text);
        }

        private void buttonCreateJob_Click(object sender, EventArgs e)
        {
            CreateJobForm createForm = new CreateJobForm(_user, connectionStringProvider);
            createForm.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        private void SetupListViewColumns()
        {
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Company Name", 200);
            listView1.Columns.Add("Job Type", 100);
            listView1.Columns.Add("Location", 150);
            listView1.Columns.Add("Apply Date", 120);
            listView1.Columns.Add("Response Date", 120);
            listView1.Columns.Add("Accepted", 80);
        }

        private void button_searchAll_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListView
            listView1.Items.Clear();

            foreach (var item in _user.Jobs)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.CompanyName.ToString());
                listViewItem.SubItems.Add(item.JobType.ToString());
                listViewItem.SubItems.Add(item.Location.ToString());
                listViewItem.SubItems.Add(item.ApplyDate.Date.ToShortDateString());
                listViewItem.SubItems.Add(item.ResponseDate.Date.ToShortDateString());
                listViewItem.SubItems.Add(item.IsAccepted.ToString());

                listView1.Items.Add(listViewItem);
            }
        }


        private void AppendTextToRichBox(string line)
        {
            richTextBox1.AppendText(line);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Retrieve the data from the selected item
                int id = Convert.ToInt32(selectedItem.SubItems[0].Text);

            }
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new instance of the ColumnComparer class
            listView1.ListViewItemSorter = new ColumnComparer(e.Column);

            // Sort the items based on the clicked column
            listView1.Sort();
        }
    }
}