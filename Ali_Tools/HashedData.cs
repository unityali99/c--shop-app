using System;
using System.Security.Cryptography;
using System.Text;

namespace Ali_Tools
{
    public static class HashedData
    {
        /// <summary>
        /// A method to hash sensetive informations .
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <param name="hashedPass"></param>
        /// <returns></returns>
        public static string HashUserPass(string userName, string Password, out string hashedPass)
        {
            UTF8Encoding utfEn = new UTF8Encoding();

            byte[] bytes = utfEn.GetBytes(userName.ToLower());

            MD5CryptoServiceProvider serviceProvider = new MD5CryptoServiceProvider();

            byte[] hashBytes = serviceProvider.ComputeHash(bytes);
           
            // ---------------------------------------------------------------------------------------------------------------

            byte[] bytes2 = utfEn.GetBytes(Password.ToLower());

            byte[] hashBytes2 = serviceProvider.ComputeHash(bytes2);

            hashedPass = System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes2), "-", "");

            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes), "-", "");
        }

    }
}
