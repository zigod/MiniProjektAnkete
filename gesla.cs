using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class gesla
    {
        public static string dekriptiraj(string geslo)
        {
            byte[] data = Convert.FromBase64String(geslo);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(geslo));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string vrni = UTF8Encoding.UTF8.GetString(results);
                    return vrni;
                }
            }
        }
        ////////////////////////////////////////7
        public static string kriptiraj(string geslo)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(geslo);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(geslo));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string vrni = Convert.ToBase64String(results, 0, results.Length);
                    return vrni;
                }
            }
        }
    }
}
