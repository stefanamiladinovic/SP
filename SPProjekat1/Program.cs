using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.Json.Serialization;

namespace SPProjekat1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread serverThread = new Thread(() =>
            {   
                Server server = new Server();
                server.Start();
            });
            serverThread.Start();
        }
    }
}