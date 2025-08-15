using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Elements.Leafs
{
	public class Button : IGUIComponent
	{
		protected readonly string text;
		public Button(string text)
		{
			this.text = text;
		}
		public void Render(string indent = "")
		{
            Console.WriteLine($"{indent}[Button: {text}]");
        }
	}
}
