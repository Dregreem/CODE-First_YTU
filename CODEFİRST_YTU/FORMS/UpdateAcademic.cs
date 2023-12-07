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
    public partial class UpdateAcademic : Form
    {
        public UpdateAcademic()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (var dbContext = new YTUSYSTEM())
            {
                Academic academic = dbContext.FindAAcademic(txt_tc_academic.Text);

                if (academic != null)
                {
                    academic.Name = txt_name_academicup.Text;
                    academic.Surname = txt_surname_academicup.Text;
                    academic.Address = txt_address_academicup.Text;
                    academic.Email = txt_email_academicup.Text;
                    academic.Password = Convert.ToInt32(txt_password_academicup.Text);
                    academic.Facultycode = combo_box_academicup.Text;
                    academic.Dateofentry = Convert.ToDateTime(datetime_academicup.Text);

                    dbContext.Entry(academic).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    MessageBox.Show("Your information has been updated");
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
        }
        

       

        private void Interface_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Academic_Interface academicInterfaceForm = new Academic_Interface();
            academicInterfaceForm.Show();
        }
    }
}
