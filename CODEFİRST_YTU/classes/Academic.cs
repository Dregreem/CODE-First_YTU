using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEFİRST_YTU.classes
{
    public class Academic:Member
    {
        public string Job_Title { get; set; }
        public string Facultycode { get; set; }
        public int number_of_classes { get; set; }
        public int Total_hours_termly { get; set; }
        bool exists;

        public bool AcademicExists(string TC, int password)
        {
            var dbContext = new YTUSYSTEM();
            bool exists = dbContext.Academics.Any(stu => stu.TC == TC && stu.Password == password);
            return exists;
        }
        public void CheckaAcademic(Academic Aca)
        {
            var dbContext = new YTUSYSTEM();
            bool existingacademic = dbContext.Academics.Any(academic => academic.TC == Aca.TC);

            if (existingacademic == false)
            {
                // If student does not exist, add it
                Aca.AddaAcademic(Aca);
                MessageBox.Show("Academic has been added to the system");
                dbContext.SaveChanges();
            }
            else
            {
                // If student already exists, show a message
                MessageBox.Show("This Academic is already in the system. Please reenter your information");
            }




        }
        public bool AddaAcademic(Academic Aca)
        {
            var dbContext = new YTUSYSTEM();
            dbContext.Academics.Add(Aca);

            int result = dbContext.SaveChanges();

            exists = result > 0;
            return exists;

        }

    }
}
