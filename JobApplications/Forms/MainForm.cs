using Entitys;
using JobApplications.Forms;
using ServiceContracts.Interfaces;
using Services;

namespace JobApplications
{
    public partial class MainForm : Form
    {
        private User? _user;
        private IFilePathProvider _filePathProvider;
        private UserService _userService;
        private int _selectedId = -1;

        public MainForm(User user, IFilePathProvider filePathProvider)
        {
            InitializeComponent();
            this._user = user;
            this.Text = _user.Name;
            this._filePathProvider = filePathProvider;
            _userService = new UserService(_filePathProvider);
            labelHello.Text = "Hello, " + _user.Name + "!";
            listView1.ColumnClick += listView1_ColumnClick;
            RefreshPage();
        }


        private void RefreshPage()
        {
            if (_user.Jobs.Count == 0)
            {
                //TODO: Maybe add a error output
                listView1.Items.Clear();
            }
            else
            {
                button_searchAll_Click(null, EventArgs.Empty);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = textBox_jobTitle.Text;
            string searchCompany = textBox_search_company.Text;
        }

        private void buttonCreateJob_Click(object sender, EventArgs e)
        {
            CreateJobForm createForm = new CreateJobForm(_user, _filePathProvider);
            createForm.ShowDialog();
            RefreshPage();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (_selectedId != -1)
            {
                EditJobForm editJobForm = new EditJobForm(_user, _selectedId, _filePathProvider);
                editJobForm.ShowDialog();
            }
            RefreshPage();
        }

        private void button_searchAll_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListView
            listView1.Items.Clear();
            _user = _userService.GetUser(_user.Name);

            string searchTitle = textBox_jobTitle.Text;
            string searchCompany = textBox_search_company.Text;
            string searchLocation = textBoxLocation.Text;

            foreach (var item in _user.Jobs)
            {
                // Apply search filters
                if (!string.IsNullOrEmpty(searchTitle))
                {
                    if (item.JobTitle.IndexOf(searchTitle, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue; // Skip this item if it doesn't match the search title
                    }
                }
                if (!string.IsNullOrEmpty(searchCompany))
                {
                    if (item.CompanyName.IndexOf(searchCompany, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue; // Skip this item if it doesn't match the search company
                    }
                }
                if (!string.IsNullOrEmpty(searchLocation))
                {
                    if (item.Location.IndexOf(searchLocation, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue; // Skip this item if it doesn't match the search location
                    }
                }

                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.CompanyName.ToString());
                listViewItem.SubItems.Add(item.JobTitle.ToString());
                listViewItem.SubItems.Add(item.Location.ToString());
                listViewItem.SubItems.Add(item.ApplyDate.Date.ToShortDateString());
                listViewItem.SubItems.Add(item.Response.ToString());

                // Add the IsAccepted sub-item
                ListViewItem.ListViewSubItem isAcceptedSubItem = new ListViewItem.ListViewSubItem(listViewItem, item.Interview.ToString());
                listViewItem.SubItems.Add(isAcceptedSubItem);

                // Set the text color based on the IsAccepted value
                if (item.Interview && item.Response)
                {
                    listViewItem.ForeColor = Color.Green;
                }
                else if (item.Response)
                {
                    listViewItem.ForeColor = Color.Red;
                }
                else
                {
                    listViewItem.ForeColor = Color.Gray;
                }

                listView1.Items.Add(listViewItem);
            }

            textBox_jobTitle.Text = "";
            textBox_search_company.Text = "";
            textBoxLocation.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Retrieve the data from the selected item
                _selectedId = Convert.ToInt32(selectedItem.SubItems[0].Text);
            }
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnComparer comparer = null;
            bool isSameColumn = false;

            if (listView1.ListViewItemSorter is ColumnComparer columnComparer)
            {
                comparer = columnComparer;
                isSameColumn = comparer.ColumnIndex == e.Column;
            }

            // Determine the sort order (toggle between ascending and descending)
            bool isDescending = comparer != null && isSameColumn && comparer.IsDescending;
            isDescending = !isDescending;

            // Create a new instance of ColumnComparer with the column index and sort order
            listView1.ListViewItemSorter = new ColumnComparer(e.Column, isDescending);

            // Perform the sorting
            listView1.Sort();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void labelLocation_Click(object sender, EventArgs e)
        {

        }
    }
}