using System.Security.Cryptography;
using System.Text;

namespace Api.Infra.Crypto;

public class Hasher
{
    private readonly string _key;
    public Hasher()
    {
        _key = "PAITINIHO";
    }

    public string Encrypt(string input) => Computed(input, _key);
    public bool Verify(string input, string hash) => Computed(input, _key) == hash;
    
    private static string Computed(string input, string key)
    {
        var inputKey = input + key;

        var bytes = Encoding.UTF8.GetBytes(inputKey);
        var hashBytes = SHA512.HashData(bytes);

        return StringBytes(hashBytes);
    }
    private static string StringBytes(byte[] bytes)
    {
        var sb = new StringBuilder();
        foreach (byte b in bytes)
        {
            var hex = b.ToString("x2");
            sb.Append(hex);
        }

        return sb.ToString();
    }
}
