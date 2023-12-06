using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFİRST_YTU.classes
{
    public class YTUSYSTEM : DbContext
    {
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Electivecourses> Electivecourses { get; set; }
        public DbSet<Required_Courses> Required_Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }

}
