using System.Security.Cryptography;
using System.Text;

public class HashGenerator
{
    public static string Generate(string plan_text)
    {
        byte[] bytearray = Encoding.Unicode.GetBytes(plan_text);
        byte[] hashed = HashAlgorithm.Create("MD5").ComputeHash(bytearray);
        return Convert.ToBase64String(hashed);
    }
}