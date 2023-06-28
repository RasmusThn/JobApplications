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
            AppendTextToRichBox("Logged in as: " + _user.Name);
            listView1.ColumnClick += listView1_ColumnClick;
            RefreshPage();
        }

       
        private void RefreshPage()
        {
            if (_user.Jobs.Count == 0)
            {
                AppendTextToRichBox("No jobs added");
                listView1.Items.Clear();
            }
            else
            {
                button_searchAll_Click(null, EventArgs.Empty);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AppendTextToRichBox(textBox_search_company.Text);
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
                EditJobForm editJobForm = new EditJobForm(_user,_selectedId, _filePathProvider);
                editJobForm.ShowDialog();
            }
            RefreshPage();
        }

        private void button_searchAll_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListView
            listView1.Items.Clear();
            _user = _userService.GetUser(_user.Name);

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
            listView1.ListViewItemSorter = new ColumnComparer(e.Column);

            listView1.Sort();
        }
        private void AppendTextToRichBox(string line)
        {
            richTextBox1.AppendText(line + Environment.NewLine);
        }
    }
}