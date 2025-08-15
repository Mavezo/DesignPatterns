using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
	public class GameManager
	{
		private static readonly GameManager instance = new GameManager();
		public static GameManager Instance => instance;
		private GameManager() { }
		public int Score { get; set; }
	}
}
