using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;

namespace SMSWebAPI.Controllers
{
    public class AccountController : ApiController
    {
        DalLayer dal = new DalLayer();

        [Route("api/Account/LoginStudent")]
        [HttpPost]
        public bool LoginStudent(Student student)
        {
            return dal.LoginStudent(student.Id, student.Password);
        }

        [Route("api/Account/LoginFaculty")]
        [HttpPost]
        public bool LoginFaculty(Faculty faculty)
        {
            return dal.LoginFaculty(faculty.Id, faculty.Password);
        }

        [Route("api/Account/ReteriveId")]
        [HttpGet]
        public int ReteriveId()
        {
            return dal.ReteriveId();
        }
    }
}
