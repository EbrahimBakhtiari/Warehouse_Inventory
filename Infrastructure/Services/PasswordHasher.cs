using Infrastructure.IServices;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Infrastructure.Services
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] salt = new byte[128 / 8]; // Generate a 128-bit salt
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return $"{Convert.ToBase64String(salt)}:{hashed}";
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            var parts = hashedPassword.Split(':', 2);
            if (parts.Length != 2)
            {
                throw new FormatException("Unexpected hash format. Should be formatted as `{salt}:{hash}`");
            }

            var salt = Convert.FromBase64String(parts[0]);
            var passwordHash = parts[1];

            var providedPasswordHash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: providedPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return passwordHash == providedPasswordHash;
        }
    }
}
