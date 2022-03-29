using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public  class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split();

            string commandInfo = input[0];
            string[] value = input.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandInfo + "Command");

            if (type == null)
            {
                throw new InvalidOperationException("Missing command!");
            }

            Type commandInterface = type.GetInterface("ICommand");
            if (commandInterface == null)
            {
                throw new InvalidOperationException("Not a command!");
            }

            var command = Activator.CreateInstance(type) as ICommand;
                    
            string result = command.Execute(value);
            return result;
        }
    }
}