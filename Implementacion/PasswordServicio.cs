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
        public string HashPassword(string password)
        {
            string hashedPassword;
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: salt, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8));
            return hashedPassword;
        }
    }
}