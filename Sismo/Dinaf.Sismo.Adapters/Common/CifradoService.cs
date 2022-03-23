using Dinaf.Sismo.Application.Common;
using System;
using System.Security.Cryptography;

namespace Dinaf.Sismo.Adapters.Common
{
    public class CifradoService : ICifradoService
    {
        public const int SALT_SIZE = 24;
        public const int HASH_SIZE = 20;
        public const int ITERATIONS = 1000;
        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF_INDEX = 2;

        public string CifrarContraseña(string password)
        {
            RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            cryptoProvider.GetBytes(salt);

            var hash = GetPbkdf2Bytes(password, salt, ITERATIONS, HASH_SIZE);
            return ITERATIONS + ":" +
                   Convert.ToBase64String(salt) + ":" +
                   Convert.ToBase64String(hash);
        }

        private byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;

            return pbkdf2.GetBytes(outputBytes);
        }

        public bool ValidarContraseña(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            var split = correctHash.Split(delimiter);
            var iterations = Int32.Parse(split[ITERATION_INDEX]);
            var salt = Convert.FromBase64String(split[SALT_INDEX]);
            var hash = Convert.FromBase64String(split[PBKDF_INDEX]);

            var testHash = GetPbkdf2Bytes(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }
    }
}