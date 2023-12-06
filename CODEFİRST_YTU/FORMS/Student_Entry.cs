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
    public partial class Student_Entry : Form
    {
        Student_Entry student_Entry;
        Main_interface main_Interface=new Main_interface();
        
        Student_Interface student_Interface= new Student_Interface();
        


        public Student_Entry()
        {
            InitializeComponent();
            student_Entry = this;
        }

        private void Mainpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            student_Entry.Hide();
            main_Interface.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            if(student.TCcontrolStudent(txt_tc_student.Text))
            {
                student.TC = txt_tc_student.Text;
                student.Password = Convert.ToInt32(txt_password_student.Text);
                bool res = student.StudentExists(student.TC, student.Password);
                MessageBox.Show("System entry is succesful Welcome to the System ");
                await Task.Delay(2000);
                student_Entry.Hide();
                student_Interface.Show();
            }
            else
            {
                MessageBox.Show("System entry is unsuccesful control your password and TC");
                student.TC = "";
                student.Password = 0;

            }


        }

    }
}
