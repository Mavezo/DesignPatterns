using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter
{
	public class SystemTextJsonAdapter : IJsonSerializer
	{
		private readonly JsonSerializerOptions? options;
		public SystemTextJsonAdapter(JsonSerializerOptions? options = null)
		{
			this.options = options ?? new JsonSerializerOptions
			{
				WriteIndented = true
			};
		}

		T IJsonSerializer.Deserialize<T>(string json)
		{
			return JsonSerializer.Deserialize<T>(json, options)!;
		}

		string IJsonSerializer.Serialize<T>(T obj)
		{
			return JsonSerializer.Serialize(obj, options);
		}
	}
}
