using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

	public sealed class DemoSingleton 
	{
		#region Singleton
		private readonly static DemoSingleton _instance = new DemoSingleton();

		public static DemoSingleton Current
		{
			get
			{
				return _instance;
			}
		}

		private DemoSingleton()
		{
			//Implent here the initialization of your singleton
		}
		#endregion

		public String Path { get; set; }

		public int Sumar(int a, int b)
		{
			return a + b;
		}
	}

	public static class DemoStatic
	{
		public static int Nro { get; set; }

		public static String Path { get; set; }

	}
}
