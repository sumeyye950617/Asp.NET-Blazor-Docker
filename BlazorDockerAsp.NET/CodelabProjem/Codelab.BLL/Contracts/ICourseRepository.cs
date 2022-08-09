using Codelab.Common;
using Codelab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codelab.BLL.Contracts
{
    public interface ICourseRepository
    {

        public Task<Result<CourseDto>> CreateCourse(CourseDto courseDto);
        public Task<Result<CourseDto>> UpdateCourse(int courseId, CourseDto courseDto);
        public Task<Result<CourseDto>> UpdateCourseImage(int courseId, string imagePath);
        public Task<Result<CourseDto>> GetCourse(int courseId);
        public Task<Result<int>> DeleteCourse(int courseId);

        public Task<Result<IEnumerable<CourseDto>>> GetAllCourse();
    }
}
