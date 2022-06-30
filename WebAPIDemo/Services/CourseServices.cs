using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class CourseServices: ICourseServices
    {
    
        private readonly ICourseRepository _iCourseRepo;
        // Injecition of Dependancy using constructor
        public CourseServices(ICourseRepository iCourseRepo)
        {
            _iCourseRepo = iCourseRepo;
        }
        public int AddCourse(Course c)
        {
            return _iCourseRepo.AddCourse(c);
        }
        public int DeleteCourse(int id)
        {
            return _iCourseRepo.DeleteCourse(id);
        }
        public IEnumerable<Course> GetAllCourse()
        {
            return _iCourseRepo.GetAllCourse();
        }
        public int Modifycourse(Course c)
        {
            return _iCourseRepo.ModifyCourse(c);
        }

        public int ModifyCourse(Course c)
        {
            throw new NotImplementedException();
        }
    }

}


   
