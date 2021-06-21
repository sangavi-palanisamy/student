using Student.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace Student.Core.IServices
{
    public interface IServices
    {
        public StudentLogin StudentLogin(StudentLogin Login);
        public Studententry CreateDetails(Studententry ob);
        public IEnumerable<Studententry> StudentDisplay();
    }
}

