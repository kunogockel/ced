// ced
// A basic console editor
// 2022-12-12 KG Created
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ced
{
    /// <summary>
    /// Implements the console editor
    /// </summary>
    class Program
    {
        /// <summary>
        /// name of the currently loaded file
        /// </summary>
        static string m_filename = "";

        /// <summary>
        /// lines of the loaded file
        /// </summary>
        static List<string> m_lines = new List<string>();

        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: ced filename");
                return;
            }
            m_filename = args[0];
            if (!loadFile())
                return;
        }

        /// <summary>
        /// Loads the file specified in m_filename.
        /// </summary>
        static bool loadFile()
        {
            bool result = true;
            try
            {
                if (!File.Exists(m_filename))
                {
                    Console.WriteLine("File not found!");
                    return false;
                }
                m_lines.AddRange(File.ReadAllLines(m_filename));
                Console.WriteLine("File loaded, {0} lines");
            }
            catch (Exception ex)
            {
                Console.WriteLine("loadFile: {0}", ex.Message);
                result = false;
            }
            return result;
        }


        static bool template()
        {
            bool result = true;
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("loadFile: {0}", ex.Message);
                result = false;
            }
            return result;
        }
    }
}
