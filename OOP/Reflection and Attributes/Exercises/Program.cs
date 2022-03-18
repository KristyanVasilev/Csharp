using System;
using System.Reflection;

namespace ReflectionAndAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            var instance = (Student)Activator.CreateInstance(type, "Gosho");
            instance.Hi();
            Console.WriteLine(32 | 16 | 8 | 4);
            Console.WriteLine(((BindingFlags)60));
            var fields = type.GetFields((BindingFlags)60);

            foreach (var field in fields)
            {
                Console.WriteLine($"Field: ---› {field.Name}");
                Console.WriteLine(field.IsStatic);
                Console.WriteLine(field.FieldType);
                Console.WriteLine(field.GetValue(instance));
                Console.WriteLine(field.IsPublic);
                Console.WriteLine(field.IsFamily);
                Console.WriteLine(field.IsPrivate);
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        private string name;
        private static string cheatingBuddy = "pesho";
        private string cheatingCodes = "45, 356";

        public Student(string name)
        {
            this.name = name;
        }

        public void Hi()
        {
            Console.WriteLine($"Hello from {this.name}");
        }
    }
}
