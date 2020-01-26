namespace ProblemHarvestingFields
{
    using ProblemHarvestingFields.Contracts;
    using System;
    using System.Reflection;
    using System.Text;
    using System.Linq;

    public class Command : ICommand
    {
        private Type classType;
        private string command;

        public Command(Type classType, string command)
        {
            this.classType = classType;
            this.command = command;
        }

        public string CommandImplemantation()
        {
            FieldInfo[] fields = this.classType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            FieldInfo[] fieldsInfoToPrint = null;

            switch (this.command)
            {
                case "public":
                    {
                        fieldsInfoToPrint = fields.Where(x => x.IsPublic).ToArray();
                        break;
                    }
                case "private":
                    {
                        fieldsInfoToPrint = fields.Where(x => x.IsPrivate).ToArray();
                        break;
                    }
                case "protected":
                    {
                        fieldsInfoToPrint = fields.Where(x => x.IsFamily).ToArray();
                        break;
                    }
                default:
                    fieldsInfoToPrint = fields;
                    break;
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var field in fieldsInfoToPrint)
            {
                string accessModifire = field.Attributes.ToString().ToLower() == "family" 
                    ? "protected" 
                    : field.Attributes.ToString().ToLower();

                stringBuilder.AppendLine($"{accessModifire} {field.FieldType.Name} {field.Name}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
