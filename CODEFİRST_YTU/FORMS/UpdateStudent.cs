using CODEFİRST_YTU.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEFİRST_YTU.FORMS
{
    public  partial class UpdateStudent : Form
    {
       
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void Interface_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Student_Interface studentInterfaceForm = new Student_Interface();
            studentInterfaceForm.Show();

        }

        private void student_register_button_Click(object sender, EventArgs e)
        {
            using (var dbContext = new YTUSYSTEM())
            {
                Student student = dbContext.FindAStudent(txt_tc_student.Text);

                if (student != null)
                {
                    student.Name = txt_name_studentup.Text;
                    student.Surname = txt_surname_studentup.Text;
                    student.Address = txt_address_studentup.Text;
                    student.Email = txt_email_studentup.Text;
                    student.Password = Convert.ToInt32(txt_password_studentup.Text);
                    student.Faculty = combo_box_studentup.Text;
                    student.Department = txt_department_studentup.Text;
                    student.Dateofentry = Convert.ToDateTime(datetime_studentup.Text);
                    student.Class=Convert.ToInt32(txt_student_class_up.Text);

                    dbContext.Entry(student).State = EntityState.Modified;
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
}
