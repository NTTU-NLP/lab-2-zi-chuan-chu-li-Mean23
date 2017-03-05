using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int millisecondsTimeout = 30000;
            using (StreamReader sr = new StreamReader(@"..\..\..\..\Data\Input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        switch (ch)
                        {
                            case '\u0021':
                                Console.Write("!\n");
                                break;
                            case '\u002E':
                                Console.Write(".\n");
                                break;
                            case '\u003F':
                                Console.Write("?\n");
                                break;
                            default:
                                Console.Write(ch);
                                break;
                        }
                    }
                }
                System.Threading.Thread.Sleep(millisecondsTimeout);
            }
        }
    }
}
