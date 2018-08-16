using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ReferMeApi.Helpers
{
    public static class RandomStringHelper
    {
        /// <summary>
        /// Generates a random string of specific number of bytes
        /// </summary>
        /// <param name="numberOfBytes">Number of bytes</param>
        /// <returns></returns>
        public static string GenerateRandomString(int numberOfBytes)
        {
            var randomStringInBytes = new byte[numberOfBytes];

            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(randomStringInBytes);
            }

            return Convert.ToBase64String(randomStringInBytes);

        }
    }
}
