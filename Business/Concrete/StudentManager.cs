﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Hashing;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly EfStudentDal _studentDal;

        public StudentManager(EfStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(StudentRegisterDto registerDto)
        {
            byte[] paswordHash, paswordSalt;
            HashingHelper.CreatePasswordHash(registerDto.Password, out paswordHash, out paswordSalt);
            Student student = new Student()
            {
                Address = registerDto.Address,
                Gender = registerDto.Gender,
                Id = 0,
                IdentityNumber = registerDto.IdentityNumber,
                IsActive = true,
                Name = registerDto.Name,
                PaswordHash = paswordHash,
                PaswordSalt = paswordSalt
            };
            _studentDal.Add(student);
        }

        public List<Student> GetList()
        {
            return _studentDal.GetList();
        }
    }
}
