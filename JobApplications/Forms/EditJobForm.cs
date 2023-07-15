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

namespace JobApplications.Forms
{
    public partial class EditJobForm : Form
    {
        private User _user;
        private int _jobId;
        private UserService _userService;

        public EditJobForm(User user, int jobId, IFilePathProvider filePathProvider)
        {
            InitializeComponent();
            _user = user;
            _jobId = jobId;
            _userService = new UserService(filePathProvider);
            SetOldValues();
        }
        private void SetOldValues()
        {
            Job? job = _user.Jobs.FirstOrDefault(x => x.Id == _jobId);
            if (job != null)
            {
                textBox_company.Text = job.CompanyName;
                textBox_Job_Title.Text = job.JobTitle;
                textBox_location.Text = job.Location;
                dateTimePicker_apply.Value = job.ApplyDate;
                checkBoxResponse.Checked = job.Response;
                checkBox_accepted.Checked = job.Interview;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Job job = _user.Jobs.FirstOrDefault(x => x.Id == _jobId);
            if (job != null)
            {
                // Update the job object with the new values from UI elements
                job.CompanyName = textBox_company.Text;
                job.JobTitle = textBox_Job_Title.Text;
                job.Location = textBox_location.Text;
                job.ApplyDate = dateTimePicker_apply.Value;
                job.Response = checkBoxResponse.Checked;
                //job.Interview = checkBox_accepted.Checked;

                if (checkBoxResponse.Checked)
                {
                    job.Interview = checkBox_accepted.Checked;
                }
                else
                {
                    job.Interview = false;
                    checkBox_accepted.Checked = false;
                }
            }

            _userService.UpdateUser(_user);


            // Close the form or perform any necessary UI updates
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            Job job = _user.Jobs.FirstOrDefault(x => x.Id == _jobId);
            if (job != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this job?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _user.Jobs.Remove(job);
                    _userService.UpdateUser(_user);
                    this.Close();
                }
            }
        }
    }
}
