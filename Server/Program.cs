using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static ServerObject _server; // сервер
        static Thread _listenThread; // потока для прослушивания
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                _server = new ServerObject();
                _listenThread = new Thread(new ThreadStart(_server.Listen));
                _listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                _server.Disconnect();
                Console.WriteLine(ex.Message);
            }

        }
    }
}
