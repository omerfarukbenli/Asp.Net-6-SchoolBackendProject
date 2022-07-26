using Business.Abstract;
using Business.Constans;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Results.Abstract;
using DataAccess.Results.Concrete;
using DataAccess.Validation;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {
        private ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        [ValidationAspect(typeof(LessonValidator))]
        public IResult Add(Lesson lesson)
        {
            //Validation Kontrol
            _lessonDal.Add(lesson);
            //Log, Cachle
            return new SuccessResult(Messages.AddedLesson);
        }

        public IResult Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
            return new SuccessResult(Messages.UpdateLesson);
        }

        public IDataResult<Lesson> GetById(int id)
        {
            var result = _lessonDal.Get(p => p.Id == id);
            return new SuccessDataResult<Lesson>(result);
        }

        public IDataResult<List<Lesson>> GetList()
        {
            var result = _lessonDal.GetList();
            return new SuccessDataResult<List<Lesson>>(result);
        }
    }
}
