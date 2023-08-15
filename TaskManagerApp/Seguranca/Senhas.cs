using System.Security.Cryptography;
using System.Text;

namespace TaskManagerApp.Seguranca
{
    internal class Senhas
    {
        public string? Senha { get; private set; }

        const int keySize = 64;
        const int iterations = 350000;

        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        public string CriptografarSenha(string senha, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(senha),
                salt,
                iterations,
                hashAlgorithm,
                keySize
                );

            return Convert.ToHexString(hash);
        }

        public bool VerificarSenha(string senha, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(senha, salt, iterations, hashAlgorithm, keySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }

        public void RegistraSenha(string senha)
        {
            Senha = senha;
        }
    }
}
