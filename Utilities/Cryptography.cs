using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Utilities
{
    public static class Cryptography
    {
        public static byte[] GenerateSalt(int length = 16)
        {

            byte[] salt = new byte[length];
            RandomNumberGenerator.Fill(salt);
            return salt;
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
            {
                argon2.Salt = salt;
                argon2.DegreeOfParallelism = 1; // number of threads
                argon2.MemorySize = 32768;      // 64 MB
                argon2.Iterations = 2;          // number of passes

                return argon2.GetBytes(32);     // desired hash length (e.g. 256-bit)
            }
        }

    }
}
