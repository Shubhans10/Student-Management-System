using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DataAccessLayer;
using Entities;

namespace SMSWebAPI.Controllers
{
    public class FacultyController : ApiController
    {
        DalLayer dal ;
        public FacultyController()
        {
            dal = new DalLayer();
        }
        

        #region Faculty 
        [Route("api/Faculty/GetAllStudents")]
        [HttpGet]
        [Authorize]
        public List<Student> GetStudents()
        {
            var result = dal.GetStudents();
            return result;
        }

        [Route("api/Faculty/GetAllEnrollements")]
        [HttpGet]
        [Authorize]
        public List<Enrollment> GetEnrollment()
        {
            var result = dal.GetEnrollment();
            return result;
        }

        [Route("api/Faculty/GetAllColleges")]
        [HttpGet]
        [Authorize]
        public List<College> GetCollege()
        {
            var result = dal.GetCollege();
            return result;
        }




        [Route("api/Faculty/AddStudent")]
        [HttpPost]
        public void AddStudent(Student stud)
        {
            dal.AddStudent(stud);
        }

        [Route("api/Faculty/AddCourse")]
        [HttpPost]
        
        public void AddCourse(Course course)
        {
            dal.AddCourse(course);
        }

        [Route("api/Faculty/AddEnrollment")]
        [HttpPost]
        public void AddEnrollement(Enrollment enrollment)
        {
            dal.AddEnrollement(enrollment);
        }

        [Route("api/Faculty/AddCollege")]
        [HttpPost]
        public void AddCollege(College college)
        {
            dal.AddCollege(college);
        }
        
        
        [Route("api/Faculty/FilterStudentDetialsByStudentId/{Id}")]
        [HttpGet]
        public Student FilterStudentDetialsByStudentId(int Id)
        {
            var StudentDetails = dal.FilterStudentDetialsByStudentId(Id);
            return StudentDetails;
        }

        [Route("api/Faculty/FilterStudentDetialsByCollegeId/{Id}")]
        [HttpGet]
        public List<Student> FilterStudentDetialsByCollegeId(int Id)
        {
            var StudentDetails = dal.FilterStudentDetialsByCollegeId(Id);
            return StudentDetails;
        }

        [Route("api/Faculty/FilterEnrollemntDetialsByCourseId/{Id}")]
        [HttpGet]
        public List<Enrollment> FilterEnrollemntDetialsByCourseId(int Id)
        {
            var EnrollementDetails = dal.FilterEnrollemntDetialsByCourseId(Id);
            return EnrollementDetails;
        }

        [Route("api/Faculty/FilterEnrollemntDetialsByStudentId/{Id}")]
        [HttpGet]
        public List<Enrollment> FilterEnrollemntDetialsByStudentId(int Id)
        {
            var EnrollementDetails = dal.FilterEnrollemntDetialsByStudentId(Id);
            return EnrollementDetails;
        }

        [Route("api/Faculty/UpdateCollege")]
        [HttpPut]
        public void UpdateCollege(College college)
        {
            dal.UpdateCollege(college);
        }

        [Route("api/Faculty/UpdateCourse")]
        [HttpPut]
        public void UpdateCourse(Course course)
        {
            dal.UpdateCourse(course);
        }

        [Route("api/Faculty/UpdateEnrollment")]
        [HttpPut]
        public void UpdateEnrollment(Enrollment enrollment)
        {
            dal.UpdateEnrollment(enrollment);
        }
        #endregion
    }
}
