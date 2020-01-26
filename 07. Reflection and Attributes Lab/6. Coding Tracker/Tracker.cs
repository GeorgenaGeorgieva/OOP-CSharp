using System.Linq;
using System.Reflection;
using System.Text;

namespace CodingTracker
{
    public class Tracker
    {
        public string PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);

            var methods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.Static);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attr in attributes)
                    {
                        stringBuilder.AppendLine($"{method.Name} is written by {attr.Name}");
                    }
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
