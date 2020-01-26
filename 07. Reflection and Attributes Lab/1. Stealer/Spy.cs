namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Assembly.GetCallingAssembly()
               .GetTypes()
               .FirstOrDefault(x => x.Name == investigatedClass);

            if (classType is null)
            {
                throw new ArgumentException("Invalid class type!");
            }

            FieldInfo[] classFileds = classType.GetFields(
                BindingFlags.Instance 
                | BindingFlags.Static 
                | BindingFlags.NonPublic 
                | BindingFlags.Public);

            StringBuilder stringBuilder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFileds.Where(f => requestedFields.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
