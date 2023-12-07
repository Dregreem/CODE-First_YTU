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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CODEFİRST_YTU.FORMS
{
    public partial class Course_interface : Form
    {
        
        
        public Course_interface()
        {
            InitializeComponent();
        }

        private void enter_system_Click(object sender, EventArgs e)
        {
            Student student = RetrieveStudent(txt_course_student_tc.Text);
            if (student != null)
            {
                MessageBox.Show("Student is found, please choose Courses");
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        private void List_courses_Click(object sender, EventArgs e)
        {
            using(var Dbcontext = new YTUSYSTEM())
            {
                Student student = RetrieveStudent(txt_course_student_tc.Text);
                if (student != null)
                {
                    Listviewcourses.Items.Clear();
                    List<Courses> Mycourses=new List<Courses>();

                    foreach (var Coursescodes in student.Classes)
                    {
                        Mycourses.Add(
                            Dbcontext.Courses.Where(courses => courses.Code == Coursescodes).FirstOrDefault());
                    }
                    foreach (var course in Mycourses)
                    {
                        ListViewItem item = new ListViewItem(course.Code);
                        item.SubItems.Add(course.Name_of_the_class);
                        item.SubItems.Add(course.Type);
                        item.SubItems.Add(course.Number_of_classes_weekly.ToString());
                        item.SubItems.Add(course.Number_of_application_weekly.ToString());
                        item.SubItems.Add(course.Number_of_lab_weekly.ToString());
                        item.SubItems.Add(course.Class.ToString());
                        item.SubItems.Add(course.Creditscore.ToString());
                        item.SubItems.Add(course.AKTSscore.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
            
        }

        private Student RetrieveStudent(string studentTC)
        {
            using (var dbContext = new YTUSYSTEM())
            {
                Student student = dbContext.FindAStudent(studentTC);
                return student;
            }
        }

        private void add_courses_Click(object sender, EventArgs e)
        {
            using (var Dbcontext = new YTUSYSTEM())
            {
                Student student = RetrieveStudent(txt_course_student_tc.Text);
                ListViewItem item = new ListViewItem();
                if (student != null)
                {
                    Listviewcourses.Items.Clear();
                    foreach (var course in Dbcontext.Courses.Where(courses => courses.Class <= student.Class))
                    {
                        
                        course.Code = item.SubItems[0].ToString();
                        item.SubItems.Add(course.Name_of_the_class);
                        item.SubItems.Add(course.Type);
                        item.SubItems.Add(course.Number_of_classes_weekly.ToString());
                        item.SubItems.Add(course.Number_of_application_weekly.ToString());
                        item.SubItems.Add(course.Number_of_lab_weekly.ToString());
                        item.SubItems.Add(course.Class.ToString());
                        item.SubItems.Add(course.Creditscore.ToString());
                        item.SubItems.Add(course.AKTSscore.ToString());
                    }

                   
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
                if (item.Selected)
                {
                    student.Classes.Add(item.SubItems[0].ToString());
                }
            }
        }
    }
}

