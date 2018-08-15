using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server is running...");
            IPAddress ip = new IPAddress(new byte[] { 192, 168, 1, 7 });

            TcpListener listener = new TcpListener(ip, 8500);
            listener.Start();
            Console.WriteLine("Listener is starting...");
            Console.WriteLine("Type Q key to exist....");

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Q);
        }
    }
}
