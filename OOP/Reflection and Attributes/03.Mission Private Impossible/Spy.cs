using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
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
