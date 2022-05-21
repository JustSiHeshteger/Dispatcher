using DispatcherAdmin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DispatcherAdmin.Service
{
    internal class ServerConnection
    {
        private readonly int port = 1337;
        //private readonly string host = "127.0.0.1";
        private readonly string host = "3.73.109.65";

        private TcpClient _client;
        private NetworkStream _stream;
        private BinaryReader _reader;
        private BinaryWriter _writer;

        public void ConnectAsync()
        {
            _client = new TcpClient();
            try
            {
                _client.Connect(host, port);
                _stream = _client.GetStream();
                _reader = new BinaryReader(_stream, Encoding.Unicode, true);
                _writer = new BinaryWriter(_stream, Encoding.Unicode, true);

                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                ViewException(ex.Message);
            }
        }

        /// <summary>
        /// Отправка сообщений
        /// </summary>
        /// <param name="OtputMessage"></param>
        public void SendMessage(MessageModel OtputMessage)
        {
            try
            {
                if (_writer != null)
                {
                    string message = JsonConvert.SerializeObject(OtputMessage);
                    _writer.Write(message);
                }
            }
            catch (Exception ex)
            {
                ViewException(ex.Message);
            }
        }

        /// <summary>
        /// Получение сообщений
        /// </summary>
        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    var message = JsonConvert.DeserializeObject<MessageModel>(_reader.ReadString());
                    //Установка сообщения
                }
                catch (Exception ex)
                {
                    ViewException(ex.Message);
                    Disconnect();
                }
            }
        }


        /// <summary>
        /// Отправка сообщений
        /// </summary>
        private void Disconnect()
        {
            if (_stream != null)
                _stream.Close();
            if (_client != null)
                _client.Close();
        }

        private void ViewException(string exceptionMessage) => throw new Exception(exceptionMessage);
    }
}
