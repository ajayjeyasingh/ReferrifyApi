using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferMeApi.Helpers
{
    public static class PasswordHelper
    {
        /// <summary>
        /// Computes the Pbkdf2 hash of a plain password and a salt
        /// </summary>
        /// <param name="passwordAsPlainText">Plain password string</param>
        /// <param name="salt">Salt string</param>
        /// <returns></returns>
        public static string ComputePbkdf2Hash(string passwordAsPlainText, string salt)
        {
            var hashInBytes = KeyDerivation.Pbkdf2(
                                password: passwordAsPlainText,
                                salt: Encoding.UTF8.GetBytes(salt),
                                prf: KeyDerivationPrf.HMACSHA512,
                                iterationCount: 10000,
                                numBytesRequested: 32);

            return Convert.ToBase64String(hashInBytes);
        }

        /// <summary>
        /// Generates a random string of a specific number of bytes
        /// </summary>
        /// <param name="numberOfBytes">Number of bytes</param>
        /// <returns></returns>
        public static string GenerateRandomSalt(int numberOfBytes)
        {
            return RandomStringHelper.GenerateRandomString(numberOfBytes);
        }
    }
}
