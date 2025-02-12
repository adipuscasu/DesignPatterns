using System;
using System.Text;

namespace Coding.Exercise
{
    public class CodeBuilder
    {
        private string className;
        private List<Field> fields = new List<Field>();

        public CodeBuilder(string className)
        {
            this.className = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            fields.Add(new Field { Type = type, Name = name });
            return this; // Enables method chaining
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            foreach (var field in fields)
            {
                sb.AppendLine($"  public {field.Type} {field.Name};");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        private class Field
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }
    }
}
