using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UdpConnector
{
    private readonly int MAX_BUFFER = 1024;
    private Socket socket;
    private EndPoint serverEnd;
    private IPEndPoint ipEnd;
    private byte[] sendData;

    public void InitSocket(string ip, int port)
    {
        try
        {
            IPAddress isIP = IPAddress.Parse(ip);
            ipEnd = new IPEndPoint(isIP, port);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        serverEnd = (EndPoint)sender;
        ConnectorLog.GetInstance().AddItem("Initialize completed");
    }

    public void SocketSend(string sendStr)
    {
        sendData = new byte[MAX_BUFFER];
        sendData = Encoding.ASCII.GetBytes(sendStr);
        socket.SendTo(sendData, sendData.Length, SocketFlags.None, ipEnd);
    }

    public void SocketQuit()
    {
        if (socket != null)
            socket.Close();
    }
}
