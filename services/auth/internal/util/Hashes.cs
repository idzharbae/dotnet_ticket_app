using System.Security.Cryptography;
using System;
using System.Text;

namespace AuthApp.Internal.Util { 
    public class Hashes {
        public static string GetSHA256Hash(string input) {
            HashAlgorithm hashAlgorithm = SHA256.Create();
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}