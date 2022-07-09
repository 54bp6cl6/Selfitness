using System.Text;
using System.Security.Cryptography;

namespace Selfitness.Library.Services
{
    public static class EncryptService
    {
        public static byte[] GetSHA256Strng(string original)
        {
            var sha256 = SHA256.Create();
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(original));
        }
    }
}
