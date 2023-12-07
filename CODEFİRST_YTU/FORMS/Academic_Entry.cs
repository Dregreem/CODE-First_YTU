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

        public Academic_Entry()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
            Main_interface main_Interface = new Main_interface();

            main_Interface.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Academic academic = new Academic();
            Academic_Interface academic_Interface = new Academic_Interface();

            if (academic.TCcontrolAcademic(txt_tc_academic.Text))
            {
                academic.TC = txt_tc_academic.Text;
                academic.Password = Convert.ToInt32(txt_password_academic.Text);
                bool res = academic.AcademicExists(academic.TC, academic.Password);
                MessageBox.Show("System entry is succesful Welcome to the System ");
                Hide();
                academic_Interface.Show();
            }
            else
            {
                MessageBox.Show("System entry is unsuccesful control your password and TC");

            }
        }
    }
}
