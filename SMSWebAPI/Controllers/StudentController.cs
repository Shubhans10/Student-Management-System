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
    public class StudentController : ApiController
    {
        DalLayer dal = new DalLayer();

        #region Student
        [Route ("api/Student/GetAllCourses")]
        [HttpGet]
        [Authorize]
        public List<Course> courses()
        {
            var lstCourse = dal.GetCourses();
            return lstCourse.ToList();
        }

        [Route("api/Student/GetEnrolledCourses/{Id}")]
        [HttpGet]
        [Authorize]
        public List<Enrollment> enrollment(int Id)
        {
            var lstEnrollment = dal.GetEnrollemntDetailsForStudent(Id).ToList();
            return lstEnrollment;
        }

        [Route("api/Student/GetOwnDetials/{Id}")]
        [HttpGet]
        [Authorize]
        public Student StudentDetials(int Id)
        {
            var studentDetails = dal.GetStudentDetailsForStudent(Id);
            return studentDetails;
        }

        [Route("api/Student/UpdateOwnDetials")]
        [HttpPut]
        [Authorize]
        public void UpdateStudent(Student stud)
        {
            dal.UpdateStudent(stud);
        }
        #endregion
    }
}
