using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiningHallProject
{
    class PasswordHandler
    {
        public string Salt { get; set;}
        private const int SaltLength = 32;
        public PasswordHandler()
        {
            Salt = GenerateSalt();
        }

        // Generate Salt
        // Return salt as string
        private string GenerateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SaltLength];
            rng.GetBytes(salt);

            return Convert.ToBase64String(salt);
        }

        // Generate Hash
        // Take password as arg
        // Return hashed password
        public string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();
            var passwordBytes = Encoding.Default.GetBytes(password);
            var hashedPassword = hash.ComputeHash(passwordBytes);
            return Convert.ToBase64String(hashedPassword);

        }
    }
}
