
using CODEFİRST_YTU.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEFİRST_YTU.classes
{
    public class Student : Member
    {

         
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Department { get; set; }
        public List<string> Classes { get; set; }
        public int? TotalCredit { get; set; }
        public int? TotalAKTS { get; set; }
        public int Class { get; set; }
        [Required]

        bool exists;
        

        public bool StudentExists(string TC, int password)
        {
           var dbContext = new YTUSYSTEM();
           exists = dbContext.Students.Any(stu => stu.TC == TC && stu.Password == password);
            return exists;
        }
        public void  CheckaStudent(Student Stu)
        {
            var dbContext = new YTUSYSTEM();
            bool existingStudent = dbContext.Students.Any(student=>student.TC==Stu.TC);

            if (existingStudent == false)
            {
                // If student does not exist, add it
                Stu.AddaStudent(Stu);
                MessageBox.Show("Student has been added to the system");
                dbContext.SaveChanges();
            }
            else
            {
                // If student already exists, show a message
                MessageBox.Show("This student is already in the system. Please reenter your information");
            }




        }
        public bool AddaStudent(Student Stu)
        {
            var dbContext = new YTUSYSTEM();
            dbContext.Students.Add(Stu);

            int result = dbContext.SaveChanges();

            exists = result > 0;
            return exists;

        }
        




    }
}
