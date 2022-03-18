using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();

            var hackerType = Type.GetType(className);

            MethodInfo[] methods =
                hackerType.GetMethods((BindingFlags)60); //all methods

            foreach (var method in methods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in methods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString();
        }
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            var hackerType = Type.GetType(className);

            MethodInfo[] methods =
                hackerType.GetMethods((BindingFlags)36); //Non public -> 32 & Instance -> 4

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {hackerType.BaseType.Name}");

            foreach (var method in methods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString();
        }
    }
}
