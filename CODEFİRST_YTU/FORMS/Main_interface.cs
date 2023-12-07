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
    public partial class Main_interface : Form
    {
        public Main_interface()
        {
            InitializeComponent();
        }

        private void Student_Entry_Click(object sender, EventArgs e)
        {
            Student_Entry student_Entry = new Student_Entry();
            student_Entry.Show();
            Hide();
            
            
        }

        private void Academic_Entry_Click(object sender, EventArgs e)
        {
            Academic_Entry academic_Entry = new Academic_Entry(); 
            academic_Entry.Show();
            Hide();


        }

        private void Student_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_register_interface student_Register_Interface = new Student_register_interface(); 
            student_Register_Interface.Show();
            Hide();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Academic_register_interface academic_Register_Interface = new Academic_register_interface();
            academic_Register_Interface.Show();
            Hide();


        }
    }
}
