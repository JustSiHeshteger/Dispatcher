using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using DispatcherClient.Model;

namespace DispatcherClient.Services
{
    internal class ServerService
    {
        private const string host = "3.73.109.65";
        //private const string host = "127.0.0.1";
        private const int port = 1337;

        private TcpClient _client;
        private NetworkStream _stream;
        private BinaryReader _reader;

        private Thread mainThread;
        private readonly ICustomNotification _notification;

        public ServerService(ICustomNotification notification)
        {
            this._notification = notification;
        }

        public async void ConnectAsync()
        {
            _client = new TcpClient();
            try
            {
                await _client.ConnectAsync(host, port);
                _stream = _client.GetStream();
                _reader = new BinaryReader(_stream, Encoding.Unicode, true);

                mainThread = new Thread(ReceiveMessage);
                mainThread.Start();
            }
            catch (Exception ex)
            {
                _notification.Send("Ошибка", ex.Message);
                Disconnect();
            }
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    var message = JsonConvert.DeserializeObject<MessageModel>(_reader.ReadString());

                    //string autobuses = "";

                    //foreach (var autobus in message.AutobusNumber)
                    //    autobuses += autobus + " ";

                    //_notification.Send("Внимание", message.Message + autobuses);
                    _notification.Send("Внимание", message.Message);
                }
                catch (Exception ex)
                {
                    _notification.Send("Ошибка", ex.Message);
                    Disconnect();
                    break;
                }
            }
        }

        public void Disconnect()
        {
            if (_stream != null)
                _stream.Close();
            if (_client != null)
                _client.Close();
            if (_reader != null)
                _reader.Close();
        }
    }
}
