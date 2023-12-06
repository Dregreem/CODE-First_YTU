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
    public partial class Student_register_interface : Form
    {
        Main_interface main_Interface=new Main_interface();
        Student_register_interface student_register_interface;
        bool res=true;

        public Student_register_interface()
        {
            InitializeComponent();
            student_register_interface = this;
        }

        private void main_page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            student_register_interface.Hide();
            main_Interface.Show();
        }

        private void student_register_button_Click(object sender, EventArgs e)
        {
            Student student=new Student();
            student.Name = txt_name_student.Text;
            student.Surname = txt_surname_student.Text;

            res = !student.TCcontrolStudent(student.TC=txt_tc_student.Text);

            if (res)
            {
                MessageBox.Show("Your TC is wrong it must have 11 digits ");
                student.TC = "";
            }
            else
            {
                student.TC = txt_tc_student.Text;
            }
            student.Address = txt_address_student.Text;
            student.Email = txt_email_student.Text;
            student.Password=Convert.ToInt32(txt_password_student.Text);
            student.Dateofentry = Convert.ToDateTime(value: datetime_student.Value);
            student.Email = txt_email_student.Text;
            student.Faculty=Convert.ToString(combo_box_student.SelectedIndex);
            student.Department=txt_department_student.Text;

            student.CheckaStudent(student);


        }
    }
}
