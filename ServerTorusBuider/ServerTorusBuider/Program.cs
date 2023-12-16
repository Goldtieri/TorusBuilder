using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerTorusBuider
{
    class Program
    {
        private const string defaultGateway = "127.0.0.1";
        private const int PORT = 11000;
        private const int queue_length = 10; 
        private const int SIZE = 1000;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("The server is running..\n");
                // создаем сетевую конечную точку в виде IP-адреса и номера порта 
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(defaultGateway), PORT);
                Socket s1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s1.Bind(ipEndPoint); // связываем объект Socket с локальной конечной точкой
                s1.Listen(queue_length); // устанавливаем объект Socket в состояние прослушивания
                Console.WriteLine("Listening socket:\nSocket Descriptor {0}\nIP address {1}\nPort {2}\n",
                    s1.Handle, ipEndPoint.Address, ipEndPoint.Port);
                while (true) // ждем подключений клиентов в бесконечном цикле
                {
                    Console.WriteLine("\nThe server is waiting for clients to connect..");
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket s2 = s1.Accept();  // извлекает из очереди ожидающих запросов 1-й запрос на соединение и создает для его обработки новый сокет
                    Console.WriteLine("\nThe Torus Builder program is running!\n\nReceived a request from the client to establish a connection\n" +
                        "Descriptor {0}\nIP address of the client socket {1}\nPort {2}\n", s2.Handle, ((IPEndPoint)s2.RemoteEndPoint).Address,
                        ((IPEndPoint)s2.RemoteEndPoint).Port);
                    bool flag = true;
                    while (flag)
                    {
                        string dataRec = null;
                        while (true) // общение с подключившимся клиентом
                        {
                            byte[] byteRec = new byte[SIZE]; // буфер для сообщений от клиента
                                                             // получаем данные из связного объекта
                            int lenBytesReceived = s2.Receive(byteRec); // декодируем все байты из указанного массива байтов в строку 
                            dataRec += Encoding.UTF8.GetString(byteRec, 0, lenBytesReceived);
                            if (s2.Available == 0)
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Received a command from the client: {0}", dataRec);
                        if (dataRec == "rate_1" || dataRec == "rate_2" || dataRec == "rate_3" || dataRec == "rate_4" || dataRec == "rate_5")
                        {
                            string dataSend;
                            if (dataRec == "rate_1")
                                dataSend = "Is it a joke?";
                            else if (dataRec == "rate_2")
                                dataSend = "Please, don't!";
                            else if (dataRec == "rate_3")
                                dataSend = "Have a good day!";
                            else if (dataRec == "rate_4")
                                dataSend = "Thank you very much!";
                            else if (dataRec == "rate_5")
                                dataSend = "God bless you!";
                            else
                                dataSend = "";
                            byte[] byteSend = Encoding.UTF8.GetBytes(dataSend);
                            int lenBytesSend = s2.Send(byteSend);  // Передаем данные клиенту
                            Console.WriteLine("Transmitted to the client successfully: {0} bytes", lenBytesSend);
                        }
                        else if (dataRec == "Check for updates")
                        {
                            string dataSend = "You have all the latest updates installed!\nLast check time: " + Convert.ToString(DateTime.Today);
                            byte[] byteSend = Encoding.UTF8.GetBytes(dataSend);
                            int lenBytesSend = s2.Send(byteSend);  // Передаем данные клиенту
                            Console.WriteLine("Transmitted to the client successfully: {0} bytes", lenBytesSend);
                        }
                        else if (dataRec == "Building" || dataRec == "Changing the size" || dataRec == "Changing the view")
                        {
                            Console.WriteLine("Event: " + dataRec + " of the torus");
                        }
                        else if (dataRec == "quit")
                        {
                            string dataSend = "Shutting down the application..";
                            byte[] byteSend = Encoding.UTF8.GetBytes(dataSend);
                            int lenBytesSend = s2.Send(byteSend);
                            s2.Shutdown(SocketShutdown.Both);
                            s2.Close();
                            flag = false;
                            Console.WriteLine("The server has completed the connection with the client");
                        }
                        else
                        {
                            string dataSend = string.Format("Unknown command");
                            byte[] byteSend = Encoding.UTF8.GetBytes(dataSend);
                            int lenBytesSend = s2.Send(byteSend);
                            Console.WriteLine("Received a command from the client: {0}", dataRec);                    
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}