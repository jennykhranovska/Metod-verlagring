using System.Collections.Generic;
using System.Threading.Channels;

namespace Metodöverlagring
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(FormatName("Anna", "Svensson"));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FormatName("Anna", "Maria", "Svensson"));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FormatName("Anna", "Svensson", true));
            Console.ResetColor();

        }

        static string FormatName(string förnamn, string efternamn)
        {
            return $"{förnamn} {efternamn}"; // Sammanfogar förnamn och efternamn
        }

        // Andra versionen av FormatName som tar tre parametrar: förnamn, mellannamn och efternamn
        static string FormatName(string förnamn, string mellannamn, string efternamn)
        {
            return $"{förnamn} {mellannamn} {efternamn}"; // Sammanfogar förnamn, mellannamn och efternamn
        }

        static string FormatName(string förnamn, string efternamn, bool uppercase)
        {
            var full = $"{förnamn} {efternamn}"; // Sammanfoga förnamn och efternamn
            return uppercase ? full.ToUpper() : full;






        }

    }
}
