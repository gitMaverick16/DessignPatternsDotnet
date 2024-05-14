using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example02
{
    public class SecurityCamera : ISecurityCamera
    {
        private string _cameraLocation;
        public SecurityCamera(string cameraLocation)
        {
            _cameraLocation = cameraLocation;
        }
        public void DisplayLiveFeed()
        {
            Console.WriteLine($"Displaying live feed from {_cameraLocation}");
        }
    }
}
