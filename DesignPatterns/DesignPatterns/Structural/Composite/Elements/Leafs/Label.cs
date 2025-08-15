using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Elements.Leafs
{
	public class Label : IGUIComponent
	{
		private readonly string text;

		public Label(string text)
		{
			this.text = text;
		}
		public void Render(string indent = "")
		{
			Console.WriteLine($"{indent}[Label: {text}]");
        }
	}
}
