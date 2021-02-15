using System;
using System.Security.Cryptography;

namespace MiraiSharp.Library.Cryptography
{
    public class Shared
    {
        public static MD5 Md5 = MD5.Create();
        public static SHA1 Sha1 = SHA1.Create();

        public static string ConvertByteArrayToHexString(byte[] buf)
        {
            return BitConverter.ToString(buf).Replace("-", "");
        }
    }
}
