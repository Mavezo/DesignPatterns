using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Elements.Leafs
{
	public class TextBox
	{
		private readonly string placeholder;
		public TextBox(string placeholder)
		{
			this.placeholder = placeholder;
		}
		public void Render(string indent = "")
		{
			Console.WriteLine($"{indent}[TextBox: {placeholder}]");
		}
	}
}
