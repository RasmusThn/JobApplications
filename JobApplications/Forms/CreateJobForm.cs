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
    public partial class CreateJobForm : Form
    {
        private User _user;
        private Job _job;
        private IFilePathProvider _filePathProvider;
        private JobFormService _service;

        public CreateJobForm(User user)
        {
            InitializeComponent();
            _user = user;
            this.Text = _user.Name;
        }

        public CreateJobForm(User user, IFilePathProvider filePathProvider) : this(user)
        {
            this._filePathProvider = filePathProvider;
            _service = new JobFormService(_filePathProvider);
        }

        private void button_createJob_Click(object sender, EventArgs e)
        {
            _job = new Job();

            _job.CompanyName = textBox_company.Text;
            _job.Location = textBox_location.Text;
            _job.JobTitle = textBox_Job_Type.Text;
            _job.ApplyDate = dateTimePicker_create.Value;
            _job.UserName = _user.Name;
            _service.CreateJobForUser(_job, _user);
            this.Close();
        }

        private void textBox_Job_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_location_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker_create_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox_company_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelCompany_Click(object sender, EventArgs e)
        {
        }

        private void labelJobTitle_Click(object sender, EventArgs e)
        {
        }

        private void labelLocation_Click(object sender, EventArgs e)
        {
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
        }
    }
}
