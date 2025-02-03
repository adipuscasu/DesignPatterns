using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new();
        public HtmlBuilder(string rootName)
        {
            root.Name = rootName;
            this.rootName = rootName;
        }
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }
        public override string ToString() => root.ToString();
        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
}
