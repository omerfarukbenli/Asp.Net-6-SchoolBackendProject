using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] paswordHash, out byte[] paswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                paswordSalt = hmac.Key;
                paswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
