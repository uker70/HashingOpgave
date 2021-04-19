using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpgave
{
    class Hash
    {
        //MD5 hash
        public static byte[] MD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        //SHA1 hash
        public static byte[] Sha1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        //SHA256 hash
        public static byte[] Sha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        //SHA512 hash
        public static byte[] Sha512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }
    }
}
