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
        private IConnectionStringProvider _connectionStringProvider;
        private MainForm _mainForm;
        private User _user;
        private UserService _userService;

        public UserLoginForm(IConnectionStringProvider connectionStringProvider)
        {
            InitializeComponent();
            _connectionStringProvider = connectionStringProvider; 
            
            _userService = new UserService(connectionStringProvider);
        }
        private void button_login_Click(object sender, EventArgs e)
        {
           _user = _userService.GetUser(textBox_user.Text);
            _mainForm = new MainForm(_user, _connectionStringProvider);
            _mainForm.FormClosing += MainForm_FormClosing;
            _mainForm.Show();


            this.Hide();
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
            _user.Name = textBox_user.Text;
            _userService.CreateUser(_user);
            //_dataAccess.InsertUser(_user);
        }
    }
}
