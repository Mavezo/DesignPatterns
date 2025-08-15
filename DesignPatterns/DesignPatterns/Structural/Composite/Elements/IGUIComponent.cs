using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Elements
{
    public interface IGUIComponent
    {
        public void Render(string indent = "");
    }
}
