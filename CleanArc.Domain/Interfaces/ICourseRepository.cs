using CleanArc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Interfaces
{
    public interface ICourseRepository
    {
        void Add(Course course);
        IEnumerable<Course> GetCourses();
    }
}
