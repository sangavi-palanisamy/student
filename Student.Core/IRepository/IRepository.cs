using Student.Core.Models;
using Student.entity;
using System;

using System.Collections.Generic;
using System.Text;




namespace Student.Core.IRepository
{
    public interface IRepository
    {
        public StudentLogin StudentLogin(StudentLogin Login);
        public Studententry CreateDetails(Studententry ob);
        public IEnumerable<Studententry> StudentDisplay();
    }
}
