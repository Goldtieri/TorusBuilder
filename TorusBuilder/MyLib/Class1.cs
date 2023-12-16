using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MyLib
{
    public class Client
    {
        private const int PORT = 11000; // Именованные константы (порт и размер буфера)
        private const int SIZE = 512;
        private const string ip = "127.0.0.1";
        Socket s1;
        string status_msg;

        public void Connect_To_Server()
        {
            try
            {
                //Создаем удаленную конечную точку               
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), PORT);
                s1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s1.Connect(ipEndPoint);
                status_msg = "Server connection established";
            }
            catch
            {
                status_msg = "Server connection error";
            }
        }

        public string GetStatusOfConnection()
        {
            return status_msg;
        }

        public void SendCommandToServer(string rate)
        {
            try
            {
                byte[] byteSend = Encoding.UTF8.GetBytes(rate);
                s1.Send(byteSend);
            }
            catch
            {

            }
        }

        public string GetAnswerFromServer()
        {
            try
            {
                byte[] byteRec = new byte[SIZE];
                int len = s1.Receive(byteRec);
                string textServer = Encoding.UTF8.GetString(byteRec, 0, len);
                return textServer;
            }
            catch
            {
                return "No data found.";
            }
            
        }

        public void SaveToXML(double a, double b, int c, int d)
        {
            File.WriteAllText(@"D:\inner_radius.txt", Convert.ToString(a));
            File.WriteAllText(@"D:\outer_radius.txt", Convert.ToString(b));
            File.WriteAllText(@"D:\sides.txt", Convert.ToString(c));
            File.WriteAllText(@"D:\rings.txt", Convert.ToString(d));

        }
    }
}
