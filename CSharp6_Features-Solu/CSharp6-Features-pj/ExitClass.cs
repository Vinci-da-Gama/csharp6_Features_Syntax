using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp6_Features_pj
{
    internal class ExitClass
    {
        public void ExitApp()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
	        {}
        }
    }
}
