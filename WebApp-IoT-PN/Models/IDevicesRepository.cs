using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_IoT_PN.Models
{
    public interface IDevicesRepository
    {
        IEnumerable<Devices> AllDevices { get; }
    }
}
