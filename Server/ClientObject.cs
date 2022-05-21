using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class ClientObject
    {
        readonly TcpClient client;
        readonly ServerObject server; // объект сервера
        BinaryWriter _writer;
        BinaryReader _reader;

        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();

                _writer = new BinaryWriter(Stream, Encoding.Unicode, false);
                _reader = new BinaryReader(Stream, Encoding.Unicode, false);

                ///<summary>
                ///Изменить прием сообщения
                ///</summary>
                while (true)
                {
                    try
                    {
                        var message = JsonConvert.DeserializeObject<MessageModel>(_reader.ReadString());
                        Console.WriteLine($"{message.Message}");

                        var messageModel = new MessageModel() { AutobusNumber = null, Message = "Сообщение успешно отправлено" };
                        server.BroadcastMessage(messageModel);
                    }
                    catch
                    {
                        var message = JsonConvert.DeserializeObject<MessageModel>(_reader.ReadString());

                        var messageModel = new MessageModel() { AutobusNumber = null, Message = "Сообщение не было отправлено" };
                        server.BroadcastMessage(messageModel);
                        
                        Console.WriteLine($"{message.Message}");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        internal void SendMessage(MessageModel message)
        {
            string mes = JsonConvert.SerializeObject(message);
            this._writer.Write(mes);
        }

        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
