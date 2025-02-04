using System.Text;

namespace GitHubJwt
{
    internal static class StringExtensions
    {
        const beginRsaPrivateKey = "-----BEGIN RSA PRIVATE KEY-----";
        const endRsaPrivateKey = "-----END RSA PRIVATE KEY-----";
        public static string HydrateRsaVariable(this string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(!input.StartsWith(beginRsaPrivateKey))
            {
                stringBuilder.AppendLine(beginRsaPrivateKey);
            }

            stringBuilder.AppendLine(input);

            if(!input.EndsWith(endRsaPrivateKey))
            {
                stringBuilder.AppendLine(endRsaPrivateKey);
            }

            return stringBuilder.ToString();
        }
    }
}
