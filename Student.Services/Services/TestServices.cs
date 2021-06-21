using Student.Core;
using Student.Core.Models;
using System;
using System.Collections.Generic;
using Student.Core.IServices;
using Student.Core.IRepository;

namespace Student.Services
{
    public class TestServices : IServices
    {
        #region MyRegion
        IRepository _testRepository;
        public TestServices(IRepository testRepository)
        {
            _testRepository = testRepository;
        }
        #endregion

       
        public  Studententry CreateDetails(Studententry ob)
        {
            _testRepository.CreateDetails(ob);
            
            return ob;
        }
        public StudentLogin StudentLogin(StudentLogin Login)
        {
            var value=_testRepository.StudentLogin(Login);
            return value;
        }
        public IEnumerable<Studententry> StudentDisplay()
        {
            
          return _testRepository.StudentDisplay();
           
        }
    }
}
