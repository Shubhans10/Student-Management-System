using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalLayer
    {
        SMSDbContext dbCtx = new SMSDbContext();
        #region Login
        public bool LoginStudent(int UserId,string Password)
        {
            Student student = new Student();
            foreach (var item in dbCtx.Students)
            {
                if (item.Id == UserId && item.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool LoginFaculty(int UserId, string Password)
        {
            Faculty faculty = new Faculty();
            foreach (var item in dbCtx.Faculties)
            {
                if (item.Id == UserId && item.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region DisplayAll
        //Faculty
        public List<Student> GetStudents()
        {
            var lstStudents = dbCtx.Students.ToList();
            return lstStudents;
        }

        public List<Faculty> GetFaculty()
        {
            var lstFaclty = dbCtx.Faculties.ToList();
            return lstFaclty;
        }

        //Student
        public List<Course> GetCourses()
        {
            var lstCourses = dbCtx.Courses.ToList();
            return lstCourses;
        }
        //Faculty
        public List<Enrollment> GetEnrollment()
        {
            var lstEnrollments = dbCtx.Enrollments.ToList();
            return lstEnrollments;
        }
        //Faculty
        public List<College> GetCollege()
        {
            var lstColleges = dbCtx.Colleges.ToList();
            return lstColleges;
        }

        //Student
        public Student GetStudentDetailsForStudent(int Id)
        {
            var StudentDetails = dbCtx.Students.Where(o => o.Id == Id).SingleOrDefault();
            return StudentDetails;
        }
        //Student
        public List<Enrollment> GetEnrollemntDetailsForStudent(int Id)
        {
            var EnrollmentDetial = dbCtx.Enrollments.Where(o => o.StudentId== Id).ToList();
            return EnrollmentDetial;
        }
        #endregion

        #region Add
        //Faculty
        public void AddStudent(Student stud)
        {
            dbCtx.Students.Add(stud);
            dbCtx.SaveChanges();
        }
        //Faculty
        public void AddCourse(Course course)
        {
            dbCtx.Courses.Add(course);
            dbCtx.SaveChanges();
        }
        //Faculty
        public void AddEnrollement(Enrollment enrollment)
        {
            dbCtx.Enrollments.Add(enrollment);
            dbCtx.SaveChanges();
        }
        //Faculty
        public void AddCollege(College college)
        {
            dbCtx.Colleges.Add(college);
            dbCtx.SaveChanges();
        }
        #endregion

        #region Filter
        //All the filter functions are for faculty only
        public Student FilterStudentDetialsByStudentId(int Id)
        {
            var StudentDetails = dbCtx.Students.Where(o => o.Id == Id).SingleOrDefault();
            return StudentDetails;  
        }
        public List<Student> FilterStudentDetialsByCollegeId(int Id)
        {
            var StudentDetails = dbCtx.Students.Where(o => o.CollegeId == Id);
            return StudentDetails.ToList();
        }
        public List<Enrollment> FilterEnrollemntDetialsByCourseId(int Id)
        {
            var EnrollementDetails = dbCtx.Enrollments.Where(o => o.CourseId== Id);
            return EnrollementDetails.ToList();
        }
        public List<Enrollment> FilterEnrollemntDetialsByStudentId(int Id)
        {
            var EnrollementDetails = dbCtx.Enrollments.Where(o => o.StudentId== Id);
            return EnrollementDetails.ToList();
        }
        #endregion

        #region Update
        //Student
        public void UpdateStudent(Student stud)
        {
            var result = dbCtx.Students.Where(o => o.Id == stud.Id);
            if (result != null)
            {
                dbCtx.Students.Attach(stud);
                dbCtx.Entry(stud).State = EntityState.Modified;
                dbCtx.SaveChanges();
            }
        }
        //Faculty
        public void UpdateCollege(College college)
        {
            var result = dbCtx.Colleges.Where(o => o.Id == college.Id);
            if (result != null)
            {
                dbCtx.Colleges.Attach(college);
                dbCtx.Entry(college).State = EntityState.Modified;
                dbCtx.SaveChanges();
            }
        }
        //Faculty
        public void UpdateCourse(Course course)
        {
            var result = dbCtx.Courses.Where(o => o.Id == course.Id);
            if (result != null)
            {
                dbCtx.Courses.Attach(course);
                dbCtx.Entry(course).State = EntityState.Modified;
                dbCtx.SaveChanges();
            }
        }
        //Faculty
        public void UpdateEnrollment(Enrollment enrollment)
        {
            var result = dbCtx.Enrollments.Where(o => o.Id == enrollment.Id);
            if (result != null)
            {
                dbCtx.Enrollments.Attach(enrollment);
                dbCtx.Entry(enrollment).State = EntityState.Modified;
                dbCtx.SaveChanges();
            }
        }
        #endregion

        public int ReteriveId()
        {
            var lstStudents = dbCtx.Students.ToList()
                                .GroupBy(s => s.Id)
                                .SelectMany(s => s.Where(i => i.Id == s.Max(j => j.Id)))
                                .Select(s => s.Id).ToList();

            return lstStudents.Max();
            }
    }
}
