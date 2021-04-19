using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpgave
{
    class Key
    {
        //Generates key with RNGCryptoServiceProvider
        public static byte[] KeyGenerator(int length)
        {
            byte[] random = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(random);
            }

            return random;
        }
    }
}
