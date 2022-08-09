using AutoMapper;
using Codelab.BLL.Contracts;
using Codelab.Common;
using Codelab.DLL;
using Codelab.DLL.Data;
using Codelab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codelab.BLL.Implementaion
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CodelabContext _ctx;
        private readonly IMapper _mapper;

        public CourseRepository(CodelabContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;


        }
        public async Task<Result<CourseDto>> CreateCourse(CourseDto courseDto)
        {
            var course = _mapper.Map<CourseDto, Course>(courseDto);
            course.CreatedBy = "Codelab";
            var addedCourse = await _ctx.Course.AddAsync(course);
            await _ctx.SaveChangesAsync();
            var returnData = _mapper.Map<Course, CourseDto>(addedCourse.Entity);
            return new Result<CourseDto>(true, ResultConstant.RecordCreateSuccessfully, returnData);
        }

        public async Task<Result<int>> DeleteCourse(int courseId)
        {
            var courseDetails = await _ctx.Course.FindAsync(courseId);
            if (courseDetails != null)
            {
                _ctx.Course.Remove(courseDetails);
                var result = await _ctx.SaveChangesAsync();
                return new Result<int>(true, ResultConstant.RecordRemoveSuccessfully, result);
            }
            return new Result<int>(false, ResultConstant.RecordRemoveNotSuccessfully);
        }

        public async Task<Result<IEnumerable<CourseDto>>> GetAllCourse()
        {
            try
            {
                var courseDtos = _mapper.Map<IEnumerable<Course>, IEnumerable<CourseDto>>(_ctx.Course);
                return new Result<IEnumerable<CourseDto>>(true, ResultConstant.RecordFound, courseDtos, courseDtos.ToList().Count);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<CourseDto>>(false, ResultConstant.RecordNotFound);
            }
        }

        public async Task<Result<CourseDto>> GetCourse(int courseId)
        {
            try
            {
                var data = await _ctx.Course.FirstOrDefaultAsync(x => x.Id == courseId);
                var returnData = _mapper.Map<Course, CourseDto>(data);
                return new Result<CourseDto>(true, ResultConstant.RecordFound, returnData);
            }
            catch (Exception)
            {
                return new Result<CourseDto>(false, ResultConstant.RecordNotFound);
            }
        }
        public async Task<Result<CourseDto>> UpdateCourse(int courseId, CourseDto courseDto)
        {
            try
            {
                if (courseId == courseDto.Id)
                {
                    var courseDetails = await _ctx.Course.FindAsync(courseId);
                    var course = _mapper.Map<CourseDto, Course>(courseDto, courseDetails);
                    course.UpdatedBy = "Codelab";
                    course.UpdatedDate = DateTime.Now;
                    var updateCourse = _ctx.Course.Update(course);
                    await _ctx.SaveChangesAsync();
                    var returnData = _mapper.Map<Course, CourseDto>(updateCourse.Entity);
                    return new Result<CourseDto>(true, ResultConstant.RecordUpdateSuccessfully, returnData);
                }
                else
                    return new Result<CourseDto>(false, ResultConstant.RecordUpdateNotSuccessfully);
            }
            catch (Exception)
            {
                return new Result<CourseDto>(false, ResultConstant.RecordUpdateNotSuccessfully);
            }
        }

        public async Task<Result<CourseDto>> UpdateCourseImage(int courseId, string imagePath)
        {
            try
            {
                if (courseId > 0)
                {
                    var courseDetails = await _ctx.Course.FindAsync(courseId);

                    courseDetails.UpdatedBy = "Codelab";
                    courseDetails.UpdatedDate = DateTime.Now;
                    courseDetails.ImageUrl = imagePath;
                    var updateCourse = _ctx.Course.Update(courseDetails);
                    await _ctx.SaveChangesAsync();
                    var returnData = _mapper.Map<Course, CourseDto>(updateCourse.Entity);
                    return new Result<CourseDto>(true, ResultConstant.RecordUpdateSuccessfully, returnData);
                }
                else
                    return new Result<CourseDto>(false, ResultConstant.RecordUpdateNotSuccessfully);
            }
            catch (Exception)
            {
                return new Result<CourseDto>(false, ResultConstant.RecordUpdateNotSuccessfully);
            }
        }

    }
}
