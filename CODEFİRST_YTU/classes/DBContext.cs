using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEFİRST_YTU.classes
{
    public class YTUSYSTEM : DbContext
    {
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Electivecourses> Electivecourses { get; set; }
        public DbSet<Required_Courses> Required_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public Student FindAStudent(string TC)
        {
            using (var dbContext = new YTUSYSTEM())
            {
                int IDofStudent = dbContext.Students
                                             .Where(stu => stu.TC == TC)
                                             .Select(stu => (int)stu.ID)
                                             .FirstOrDefault();

                if (IDofStudent > 0)
                {
                    Student student = dbContext.Students.FirstOrDefault(stu => stu.ID == IDofStudent);
                    return student;
                }
                else
                {
                    MessageBox.Show("Couldnt find the Student");
                    return null;
                }
            }


        }
        public Academic FindAAcademic(string TC)
        {
            using (var dbContext = new YTUSYSTEM())
            {
                int IDofAcademic = dbContext.Academics
                                             .Where(stu => stu.TC == TC)
                                             .Select(stu => (int)stu.ID)
                                             .FirstOrDefault();

                if (IDofAcademic > 0)
                {
                    Academic academic = dbContext.Academics.FirstOrDefault(stu => stu.ID == IDofAcademic);
                    return academic;
                }
                else
                {
                    MessageBox.Show("Couldnt find the Academic");
                    return null;
                }
            }

        }

    }
}
