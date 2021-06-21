using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Core.Models
{
    public class Studententry
    {
       
            public int Studid { get; set; }

            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public DateTime Dateofbirth { get; set; }
            public int Studage { get; set; }
            public string Favouritesub { get; set; }
            public string Interestescourse { get; set; }
            public int Mathsmark { get; set; }
            public int Chemistrymark { get; set; }
            public int Computermark { get; set; }
        
    }
}
