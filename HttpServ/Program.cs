using System.Net;
using System.Net.Sockets;
using System.Text;

int port = 4221;
TcpListener server = new TcpListener(IPAddress.Any, port);
server.Start();

while (true)
{
    Socket socket = server.AcceptSocket();

    if (socket.Connected)
    {
        string response = "HTTP/1.1 200 OK\r\nContent-Length: 0\r\n\r\n";
        socket.Send(Encoding.UTF8.GetBytes(response));
    }

    socket.Close();
}