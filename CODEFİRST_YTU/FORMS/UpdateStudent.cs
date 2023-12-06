using CODEFİRST_YTU.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEFİRST_YTU.FORMS
{
    public partial class UpdateStudent : Form
    {
        Student_Interface student_interface=new Student_Interface();
        UpdateStudent updateStudent;
        Student student=new Student();

        public UpdateStudent()
        {
            InitializeComponent();
            updateStudent = this;
        }

        private void Interface_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            student_interface.Show();
            updateStudent.Close();
        }

        private void student_register_button_Click(object sender, EventArgs e)
        {
            var dbContext = new YTUSYSTEM();
            Student student = new Student();


            student = student.FindAStudent(txt_tc_student.Text);

            if (student != null)
            {
                // Update student properties
                student.Name = txt_name_studentup.Text;
                student.Surname = txt_surname_studentup.Text;
                student.Address = txt_address_studentup.Text;
                student.Email = txt_email_studentup.Text;
                student.Password = Convert.ToInt32(txt_password_studentup.Text);
                student.Faculty = combo_box_studentup.Text;
                student.Department = txt_department_studentup.Text;
                student.Dateofentry = Convert.ToDateTime(datetime_studentup.Text);

                // Save changes
                dbContext.SaveChanges();
                MessageBox.Show("Your information has been updated");
            }
            else
            {
                MessageBox.Show("Student not found");
            }

        }
    }
}
