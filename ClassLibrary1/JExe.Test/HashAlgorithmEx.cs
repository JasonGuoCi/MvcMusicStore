using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    public class HashAlgorithmEx
    {
        public static byte[] SHA1Algorithm(string str)
        {
            HashAlgorithm alg = HashAlgorithm.Create("SHA1");
            byte[] plainText = Encoding.Default.GetBytes(str);

            byte[] hashData = alg.ComputeHash(plainText);

            return hashData;
        }
    }
}
