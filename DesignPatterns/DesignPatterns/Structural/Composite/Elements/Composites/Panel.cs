using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Elements.Composites
{
	public class Panel : IGUIComponent
	{
		private readonly string name;
		private List<IGUIComponent> children = new();
		public Panel(string name)
		{
			this.name = name;
		}
		public void Add(IGUIComponent element)
		{
			children.Add(element);
		}
		public void Remove(IGUIComponent element)
		{
			children.Remove(element);
		}
		public void Render(string indent = "")
		{
			Console.WriteLine($"{indent}<Panel: {name}>");
            foreach (var item in children)
            {
				item.Render(indent + "	 ");
            }
        }
	}
}
