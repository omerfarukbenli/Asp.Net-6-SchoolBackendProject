using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Adminstrator : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
