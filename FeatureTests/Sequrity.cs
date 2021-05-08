using System.Security.Cryptography;
public static class Protector
{
    // salt size must be at least 8 bytes, we will use 16 bytes
    private static readonly byte[] salt = System.Text.Encoding.Unicode.GetBytes("sdfgdfg");
    // iterations must be at least 1000, we will use 2000
    private static readonly int iterations = 2000;
    public static string Encrypt(string plainText, string password)
    {
        byte[] encryptedBytes, plainBytes = System.Text.Encoding.Unicode.GetBytes(plainText);
        Aes aes = Aes.Create(); // abstract class factory method
        Rfc2898DeriveBytes pbkdf2 = new(password, salt, iterations);
        aes.Key = pbkdf2.GetBytes(32); // set a 256-bit key
        aes.IV = pbkdf2.GetBytes(16); // set a 128-bit IV
        using (var ms = new System.IO.MemoryStream())
        {
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(plainBytes, 0, plainBytes.Length);
            }
            encryptedBytes = ms.ToArray();
        }
        return System.Convert.ToBase64String(encryptedBytes);
    }
    public static string Decrypt(string cryptoText, string password)
    {
        byte[] plainBytes, cryptoBytes = System.Convert.FromBase64String(cryptoText);
        var aes = Aes.Create();
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
        aes.Key = pbkdf2.GetBytes(32);
        aes.IV = pbkdf2.GetBytes(16);
        using (var ms = new System.IO.MemoryStream())
        {
            using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cryptoBytes, 0, cryptoBytes.Length);
            }
            plainBytes = ms.ToArray();
        }
        return System.Text.Encoding.Unicode.GetString(plainBytes);
    }
}