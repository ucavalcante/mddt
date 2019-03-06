using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace mddt
{
    class Program
    {
        private static Dictionary<string, string> dArgs = new Dictionary<string, string>();
        private static string defaultSource = "https://casual-effects.com/markdeep/latest/markdeep.min.js";

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case var t when (new List<string>() { "-o", "--output" }).Contains(t):
                        if (args[i + 1].StartsWith("."))
                        {
                            var caminho = Environment.CurrentDirectory;
                            dArgs.Add("output", args[i + 1]);
                            i++;
                        }
                        else
                        {
                            var caminho = Path.GetPathRoot(args[i+1]);
                            dArgs.Add("output", caminho);
                            i++;
                        }
                        break;

                    case var t when (new List<string>() { "-h", "--help" }).Contains(t):
                        Console.WriteLine("Acertou Mizeravi");
                        break;

                        case var t when (new List<string>(){"-s", "--source"}).Contains(t):


                        break;

                    default:
                        break;
                }
            }

            foreach (var item in dArgs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
