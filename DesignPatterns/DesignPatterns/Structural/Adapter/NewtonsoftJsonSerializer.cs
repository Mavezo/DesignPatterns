using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter
{
	public class NewtonsoftJsonSerializer : IJsonSerializer
	{
		public string Serialize<T>(T obj)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
		}

		public T Deserialize<T>(string json)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json)!;
		}
	}

}
