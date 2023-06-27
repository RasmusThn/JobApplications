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
        }

        public MainForm(User user, IConnectionStringProvider connectionStringProvider) : this(user)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(textBox_search_company.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateJobForm createForm = new CreateJobForm(_user,connectionStringProvider);
            createForm.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        private void button_searchAll_Click(object sender, EventArgs e)
        {

        }
       
    }
}