namespace System
{
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        public static string Sha1(this string input)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(input);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }
            
        /// <summary>Returns the MD5 sum hash of a <see cref="T:System.String" />.</summary>
        /// <returns>A <see cref="T:System.String" /> hash of the specified <see cref="T:System.String" />.</returns>
        public static string Md5(this string input)
        {
            //Create hash
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.UTF8.GetBytes(input);
            data = x.ComputeHash(data);

            //Convert to string
            StringBuilder s = new StringBuilder();
            foreach (byte b in data)
            {
                s.Append(b.ToString("x2").ToLower());
            }

            //Done
            return s.ToString();
        }

        public static Match Match(this string input, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.Match(input, pattern, options);
        }

        public static MatchCollection Matches(this string input, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.Matches(input, pattern, options);
        }

        public static bool IsMatch(this string input, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.Match(input, pattern, options).Success;
        }

        public static string[] GetLines(this string input)
        {
            return input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
