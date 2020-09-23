using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_IoT_PN.Models
{
    public class MockDevicesRepository : IDevicesRepository
    {
        public IEnumerable<Devices> AllDevices => 
            new List<Devices>
            {
                new Devices
                {
                    DeviceId = "aa-11", DeviceName = "Living Room Light roof", Description = "Dimmable roof light in the living room", isConnected = true
                },
                new Devices
                {
                    DeviceId = "bb-22", DeviceName = "Hall Light", Description = "Dimmable roof light in the hall", isConnected = true
                },
                new Devices
                {
                    DeviceId = "cc-33", DeviceName = "Kitchen Light", Description = "Dimmable roof light in the kitchen", isConnected = false
                },
                new Devices
                {
                    DeviceId = "dd-44", DeviceName = "Living Room floor", Description = "Dimmable floor lamp in the living room", isConnected = false
                },
                new Devices
                {
                    DeviceId = "ee-55", DeviceName = "Living Room wall", Description = "Wall decoration lamp in the living room", isConnected = false
                }
            };
    }
}
