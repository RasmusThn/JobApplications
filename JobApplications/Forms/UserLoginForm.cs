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
            string username = textBox_user.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Must enter a username");
                return;
            }

            try
            {
                _user = _userService.GetUser(username);

                if (_user != null)
                {
                    _mainForm = new MainForm(_user, _filePathProvider);
                    _mainForm.FormClosing += MainForm_FormClosing;
                    _mainForm.Show();
                    // Clear the text box after successful login
                    textBox_user.Text = "";
                    errorLabel.Visible = false;

                    this.Hide();
                }
                else
                {
                    ShowError("Invalid username");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ShowError("No User with that name. \nCreate one?");
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
            string username = textBox_user.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    ShowError("Must enter a username");
                    return;
                }

                _user = new User();
                _user.Name = username;
                _userService.CreateUser(_user);

                // Clear the text box after successful user creation
                textBox_user.Text = "";

                ShowSuccessMessage("User created successfully!");
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException && ex.Message.StartsWith("A user file with the name"))
                {

                    ShowError($"Username '{username}' already exists.");
                }
                else
                {
                    ShowError(ex.Message);
                }
            }
        }
        private void ShowError(string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
        }
        private void ShowSuccessMessage(string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.Green;
            errorLabel.Visible = true;
        }
    }
}
