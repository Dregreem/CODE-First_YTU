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
    public partial class Student_Interface : Form
    {
        
        Student_Interface student_Interface;
        public Student_Interface()
        {
            InitializeComponent();
            student_Interface = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Update_information_student_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.Show();
            student_Interface.Close();

        }
    }
}
