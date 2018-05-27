using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                // Command line given, display console 
                AllocConsole();
                ConsoleMain(args);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Calc());
            }

        }

        private static void ConsoleMain(string[] args)
        {
            Console.WriteLine("Command line = {0}", Environment.CommandLine);
            for (int ix = 0; ix < args.Length; ++ix)
                Console.WriteLine("Argument{0} = {1}", ix + 1, args[ix]);
            Console.ReadLine();
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}
