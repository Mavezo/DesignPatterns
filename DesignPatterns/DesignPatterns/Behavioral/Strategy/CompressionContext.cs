using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Strategy
{
    public class CompressionContext
	{
		private ICompressionStrategy strategy;
		public CompressionContext(ICompressionStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void SetStrategy(ICompressionStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void CreateArchive(string fileName)
		{
			if (strategy is null)
			{
                Console.WriteLine("Compression strategy is not set");
				return;
            }
			strategy.Compress(fileName);
		}
	}
}
