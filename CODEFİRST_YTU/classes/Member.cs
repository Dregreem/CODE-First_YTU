
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFİRST_YTU.classes
{
    public class Member
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Dateofentry { get; set; }

        public bool TCcontrolStudent(string tc)
        {
            var dbContext = new YTUSYSTEM();

            if (tc.Length != 11&(dbContext.Students.Any(stu => stu.TC == tc)))
            {
            return false;
            }
            return true;

        }
        public bool TCcontrolAcademic(string tc)
        {
            var dbContext = new YTUSYSTEM();

            if (tc.Length != 11 & (dbContext.Academics.Any(stu => stu.TC == tc)))
            {
                return false;
            }
            return true;

        }
    }
}
