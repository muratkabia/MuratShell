using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratShell.Utils
{
	class Help
	{

		public static String commandName { get; set; }
		public static String helpString { get; set; }

		public Help(String cmdName, String hlpStr)
		{
			commandName = cmdName;
			helpString = hlpStr;
		}


		public static String getCommandName()
		{
			return commandName;
		}

		public static String getHelpString()
		{
			return helpString;
		}
	}
}
