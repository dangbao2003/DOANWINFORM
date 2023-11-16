using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    class MaHoa
    {
        public static string ToShA1(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (var item in hash)
            {
                hashSb.Append(item.ToString("X2"));

            }
            return hashSb.ToString();
        }
    }
}
