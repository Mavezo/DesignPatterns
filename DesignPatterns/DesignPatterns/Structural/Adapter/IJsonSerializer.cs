using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter
{
	public interface IJsonSerializer
	{
		public string Serialize<T>(T obj);
		public T Deserialize<T>(string json);
	}
}
