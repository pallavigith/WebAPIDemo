using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entities;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        private readonly IProductRepository _iProductRepo;
        // Injecition of Dependancy using constructor
        RepositoriesContext context;
        public CourseRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddCourse(Course c)
        {
            context.Course.Add(c);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCourse(int id)
        {
            var c= context.Course.Where(p => p.Id == id).SingleOrDefault();
            if (c != null)
            {
                context.Course.Remove(c);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return context.Course.ToList();
        }

        public int ModifyCourse(Course c)
        {
            var Course = context.Course.Where(p => p.Id == c.Id).SingleOrDefault();
            if (Course != null)
            {
                Course.Name = c.Name;
                Course.Fees = c.Fees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }

}

    