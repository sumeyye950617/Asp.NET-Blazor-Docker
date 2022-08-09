using AutoMapper;
using Codelab.DLL;
using Codelab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codelab.BLL.Mapper
{
   public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CourseDto, Course>().ReverseMap();
        }
    }
}
