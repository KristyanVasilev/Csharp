using System.Text;

namespace RenderSimpleCode
{
    public partial class Program
    {
        public class CodeBuilder
        {
            private string className;
            private StringBuilder sb;
            public CodeBuilder(string className)
            {
                this.className = className;
                this.sb = new StringBuilder();
                CreatClass();
            }

            private void CreatClass()
            {
                sb.AppendLine($"Public class {this.className}");
                sb.AppendLine("{");
            }

            public CodeBuilder AddField(string name, string type)
            {
                sb.AppendLine($"  private {type} {name};");
                return this;
            }

            public CodeBuilder AddProperty(string protectiondLvl,string name, string type)
            {
                sb.AppendLine();
                sb.AppendLine($"  {protectiondLvl} {type} {name};");
                return this;
            }

            public override string ToString()
            {
                sb.AppendLine("}");
                return this.sb.ToString().TrimEnd();
            }
        }
    }
}
