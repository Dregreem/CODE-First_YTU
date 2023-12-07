using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFİRST_YTU.classes
{
    
    public class Courses
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Class { get; set; }
        public string Type { get; set; }

        public string Name_of_the_class { get; set; }

        public int Number_of_classes_weekly { get; set; }

        public int Number_of_application_weekly { get; set; }

        public int Number_of_lab_weekly { get; set; }

        public int Creditscore { get; set; }

        public int AKTSscore { get; set; }

    }
    
    

}
