using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] commandArgs = inputArgs.Skip(1).ToArray();

            string commandName = (inputArgs[0] + "Command").ToLower();

            Type commandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName);

            if (commandType is null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand instanceType = Activator.CreateInstance(commandType) as ICommand;

            if (instanceType is null)
            {
                throw new ArgumentException("Invalid command type!");
            }
           
            string result = instanceType.Execute(commandArgs);

            return result;
        }
    }
}
