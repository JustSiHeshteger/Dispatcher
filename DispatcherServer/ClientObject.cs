using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace DispatcherServer
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
                        var message = JsonSerializer.Deserialize<MessageModel>(_reader.ReadString());
                        Console.WriteLine($"{message.Message}");

                        var messageModel = new MessageModel() { AutobusNumber = null, Message = "Сообщение успешно отправлено" };
                        server.BroadcastMessage(messageModel, this.Id);
                    }
                    catch
                    {
                        var message = JsonSerializer.Deserialize<MessageModel>(_reader.ReadString());

                        var messageModel = new MessageModel() { AutobusNumber = null, Message = "Сообщение не было отправлено" };
                        server.BroadcastMessage(messageModel, this.Id);
                        
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
            string mes = JsonSerializer.Serialize(message);
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
