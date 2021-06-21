using Student.Core;
using Student.Core.Models;
using Student.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Student.Core.IRepository;

namespace Student.Resources
{
    public class TestRepository : IRepository
    {
       
        
        public StudentLogin StudentLogin(StudentLogin ob)
        {
            using(CurdContext student = new CurdContext())
            {

           
            var logindetails = student.Login.Where(x => x.LoginName == ob.Loginname && x.Password == ob.Password).SingleOrDefault();
            if (logindetails != null)
            {
                    return ob;
            }
           
            }
            return null;

        }
        public Studententry CreateDetails(Studententry ob)
        {

            if (ob != null)
            {
                if (ob.Studid == 0)
                {

               
                    using (CurdContext student = new CurdContext())
                    { 
                    StudentRecords stud = new StudentRecords();

                    stud.FirstName = ob.FirstName;
                    stud.SecondName = ob.SecondName;
                    stud.DateOfBirth = ob.Dateofbirth;
                    stud.Age = ob.Studage;
                    stud.FavoriteSubject = ob.Favouritesub;
                    stud.InterestedCourse = ob.Interestescourse;
                    stud.MathsMark = ob.Mathsmark;
                    stud.ChemistryMark = ob.Chemistrymark;
                    stud.ComputerMark = ob.Computermark;

                    student.StudentRecords.Add(stud);
                    student.SaveChanges();
                    }
                }
                
            }
            return ob ;
        }


        public IEnumerable<Studententry> StudentDisplay()
        {
            IList<Studententry> StudentList = new List<Studententry>();
            Studententry studentclass = new Studententry();
            using (CurdContext student = new CurdContext())
            {
                var displayrecords = student.StudentRecords.Where(x => x.IsDelete == false).ToList();
                if (displayrecords != null)
                {
                    foreach (var value in displayrecords)
                    {
                       


                        studentclass.Studid = value.StudentId;
                        studentclass.FirstName = value.FirstName;
                        studentclass.SecondName = value.SecondName;
                        studentclass.Dateofbirth = value.DateOfBirth;
                        studentclass.Studage = value.Age;
                        studentclass.Favouritesub = value.FavoriteSubject;
                        studentclass.Interestescourse = value.InterestedCourse;
                        studentclass.Mathsmark = value.MathsMark;
                        studentclass.Chemistrymark = value.ChemistryMark;
                        studentclass.Computermark = value.ComputerMark;
                        StudentList.Add(studentclass);
                    }
                }
            }
            
            return StudentList;

        }
    }
}
