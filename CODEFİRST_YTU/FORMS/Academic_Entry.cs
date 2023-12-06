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
    public partial class Academic_Entry : Form
    {
        Academic_Entry academic_Entry;
        Main_interface main_Interface = new Main_interface();
        Academic_Interface student_Interface = new Academic_Interface();
        public Academic_Entry()
        {
            InitializeComponent();
            academic_Entry = this;
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            academic_Entry.Hide();
            main_Interface.Show();
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            Academic academic = new Academic();
            if (academic.TCcontrolAcademic(txt_tc_academic.Text))
            {
                academic.TC = txt_tc_academic.Text;
                academic.Password = Convert.ToInt32(txt_password_academic.Text);
                bool res = academic.AcademicExists(academic.TC, academic.Password);
                MessageBox.Show("System entry is succesful Welcome to the System ");
                await Task.Delay(2000);
                academic_Entry.Hide();
                student_Interface.Show();
            }
            else
            {
                MessageBox.Show("System entry is unsuccesful control your password and TC");

            }
        }

        
    }
}
