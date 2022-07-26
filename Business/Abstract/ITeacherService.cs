using DataAccess.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IResult Add(TeacherRegisterDto teacherRegisterDto);
        IResult Update(TeacherRegisterDto teacherRegisterDto);
        IDataResult<List<Teacher>> GetList();
        IDataResult<Teacher> GetById(int id);
    }
}
