namespace Telephony
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Smartphone : IBrowser, ICall
    {
        public string Browse(string[] urls)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var url in urls)
            {
                if (url.Any(char.IsDigit))
                {
                    stringBuilder.AppendLine("Invalid URL!");
                    continue;
                }

                stringBuilder.AppendLine($"Browsing: { url}!");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string Call(string[] phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var number in phoneNumber)
            {
                if (!number.All(char.IsDigit))
                {
                    stringBuilder.AppendLine("Invalid number!");
                    continue;
                }

                stringBuilder.AppendLine($"Calling... {number}");
            }

            return stringBuilder.ToString().TrimEnd();  
        }
    }
}
