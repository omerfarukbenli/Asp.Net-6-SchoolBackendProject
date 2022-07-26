﻿using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StudentStatus : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Description { get; set; }
    }
}
