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
    public partial class Academic_register_interface : Form
    {
        bool res = true;
        public Academic_register_interface()
        {
            InitializeComponent();
       
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Close();
            Main_interface main_Interface = new Main_interface();
            main_Interface.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Academic academic = new Academic();
            academic.Name = txt_name_academic.Text;
            academic.Surname = txt_surname_academic.Text;

            res = !academic.TCcontrolAcademic(academic.TC = txt_tc_academic.Text);

            if (res)
            {
                MessageBox.Show("Your TC is wrong it must have 11 digits ");
                academic.TC = "";
            }
            else
            {
                academic.TC = txt_tc_academic.Text;
            }
            academic.Address = txt_address_academic.Text;
            academic.Email = txt_email_academic.Text;
            academic.Password = Convert.ToInt32(txt_password_academic.Text);
            academic.Dateofentry = Convert.ToDateTime(value: datetime_academic.Value);
            academic.Email = txt_email_academic.Text;
            academic.Facultycode = Convert.ToString(combo_box_academic.SelectedIndex);
           
            academic.CheckaAcademic(academic);
        }
    }
}
