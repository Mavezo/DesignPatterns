using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Strategy.CompressionAlgorithm
{
    public class RarCompression : ICompressionStrategy
	{
		public void Compress(string fileName)
		{
            Console.WriteLine($"File {fileName} compressed using Rar");
        }
	}
}
