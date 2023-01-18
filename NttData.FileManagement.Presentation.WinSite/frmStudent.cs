using NttData.FileManagement.Business.WinSite.Contracts;
using NttData.FileManagement.Business.WinSite.Implementations;
using NttData.FileManagement.Common.Model;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NttData.FileManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            /*string path = ConfigurationManager.AppSettings.Get("FileStudentPath");
            MessageBox.Show(path);*/
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            IStudentService studentService = new StudentServiceImpl();
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Birthay = DateTime.Parse(txtBirthday.Text);
            



            studentService.Add(student);

            MessageBox.Show("Studend saved");

        }
    }
}
