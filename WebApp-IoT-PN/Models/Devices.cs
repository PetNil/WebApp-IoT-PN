using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_IoT_PN.Models
{
    public class Devices
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public bool isConnected { get; set; }
    }
}
