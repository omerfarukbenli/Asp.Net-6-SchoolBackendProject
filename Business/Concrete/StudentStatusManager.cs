using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentStatusManager : IStudentStatusService
    {
        private readonly EfStudentStatusDal _studentStatusDal;

        public StudentStatusManager(EfStudentStatusDal studentStatusDal)
        {
            _studentStatusDal = studentStatusDal;
        }
    }
}
