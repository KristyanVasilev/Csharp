

using System;

using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type hackerType = Type.GetType(investigatedClass);
            
            FieldInfo[] publicFields = hackerType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            MethodInfo[] methods =
                hackerType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            
            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo field in publicFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in methods)
            {
                if (method.Name.StartsWith("get") && method.IsPublic == false)
                {
                    sb.AppendLine($"{method.Name} have to be public!");
                }

                if (method.Name.StartsWith("set") && method.IsPrivate == false)
                {
                    sb.AppendLine($"{method.Name} have to be private!");
                }
                
            }
            return sb.ToString().TrimEnd();
        }  
    }
}
