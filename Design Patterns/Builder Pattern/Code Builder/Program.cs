using System;
using System.Collections.Generic;

namespace RenderSimpleCode
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person")
                .AddField("Name","string")
                .AddField("Age", "int")
                .AddProperty("Public","Name", "string"); //chain several cols
            Console.WriteLine(cb);
        }
    }
}
