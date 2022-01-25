using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bsp.Abfon
{
    public class Murry856
    {
        public int seconds_to_comply = 15;
        public bool keep_shooting = false;
        public string location = "place";

        public async void StopShooting(int targetId)
        {
            //TODO
        }

        public async Task<int> Shoot(int targetId)
        {
            var bothBarrels = new UdpClient(11000);
            var shots = 0;
            bothBarrels.Connect(targetId.ToString(), 11000);

            // Sends a message to the host to which you have connected.
            Byte[] sendBytes = Encoding.ASCII.GetBytes("You have 15 seconds to comply.");

            while (keep_shooting)
            {
                shots++;
                await bothBarrels.SendAsync(sendBytes, sendBytes.Length);
            }

            bothBarrels.Close();
            return shots;
        }
    }
}
