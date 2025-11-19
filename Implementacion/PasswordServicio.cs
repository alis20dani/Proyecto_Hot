using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using mi_proyecto_sena.SERVICES;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace mi_proyecto_sena.Implementacion
{
    public class PasswordServicio : IPasswordServicio
    {
        public string HashPassword(string password, out string Salt)
        {
            string hashedPassword;
            byte[] saltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            Salt = Convert.ToBase64String(saltBytes);
            hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: saltBytes, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8));
            return hashedPassword;
        }
    }
}