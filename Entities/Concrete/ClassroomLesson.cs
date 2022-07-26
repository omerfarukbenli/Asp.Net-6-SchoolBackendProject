using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ClassroomLesson : IEntity
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int LessonsId { get; set; }
    }
}
