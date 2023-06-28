using DataAccess;
using Entitys;
using ServiceContracts.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplications
{
    public partial class UserLoginForm : Form
    {
        private IFilePathProvider _filePathProvider;
        private MainForm _mainForm;
        private User _user;
        private UserService _userService;

        public UserLoginForm(IFilePathProvider filePathProvider)
        {
            InitializeComponent();
            _filePathProvider = filePathProvider;

            _userService = new UserService(filePathProvider);
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            _user = new User();
            textBoxError.Enabled = false;
            try
            {
            _user = _userService.GetUser(textBox_user.Text);

            }
            catch (Exception ex)
            {
                textBoxError.Enabled = true;
                textBoxError.Text = ex.Message;
            }
            if (_user != null)
            {

            _mainForm = new MainForm(_user, _filePathProvider);
            _mainForm.FormClosing += MainForm_FormClosing;
            _mainForm.Show();

            this.Hide();
            }
            else
            {
                textBoxError.Enabled = true;
                textBoxError.Text = "Enter Name";
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Show();

            }
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            textBoxError.Enabled = false;

            try
            {
                _user = new User();
                _user.Name = textBox_user.Text;
                _userService.CreateUser(_user);
            }
            catch (Exception ex)
            {
                textBoxError.Enabled = true;
               textBoxError.Text = ex.Message;

            }


        }
    }
}
