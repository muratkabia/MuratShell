using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratShell.Komutlar
{
	class Neofetch
	{

		private static string username = Environment.UserName;
		private static string machinename = Environment.MachineName;

		public Neofetch()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			//Console.Write(username + "@" + machinename);
			Console.Write(username);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("@");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(machinename);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("===========================");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("OS: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(Environment.OSVersion);
			Console.ResetColor();
		}
	}
}
