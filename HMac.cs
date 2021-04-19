using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpgave
{
    class HMac
    {
        public static byte[] MD5Hash(string input, byte[] key)
        {
            using (HMACMD5 md5 = new HMACMD5(key))
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        public static byte[] Sha1Hash(string input, byte[] key)
        {
            using (HMACSHA256 sha1 = new HMACSHA256(key))
            {
                return sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        public static byte[] Sha256Hash(string input, byte[] key)
        {
            using (HMACSHA256 sha256 = new HMACSHA256(key))
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        public static byte[] Sha512Hash(string input, byte[] key)
        {
            using (HMACSHA512 sha512 = new HMACSHA512(key))
            {
                return sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }
    }
}
