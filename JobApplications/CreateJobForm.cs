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
        private CreateFormService _service;  

        public CreateJobForm(User user)
        {
            InitializeComponent();
            _user = user;
            this.Text = _user.Name;
        }

        public CreateJobForm(User user, IFilePathProvider filePathProvider) : this(user)
        {
            this._filePathProvider = filePathProvider;
            _service = new CreateFormService(_filePathProvider);
        }

        private void button_createJob_Click(object sender, EventArgs e)
        {
            _job = new Job();

            _job.CompanyName = textBox_company.Text;
            _job.Location = textBox_location.Text;
            _job.JobType = textBox_Job_Type.Text;
            _job.ApplyDate = dateTimePicker_create.Value;
            _job.ResponseDate = DateTime.Now;
            _service.CreateJobForUser(_job,_user);
        }
    }
}
