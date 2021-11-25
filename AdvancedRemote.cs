using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice _device) : base(_device)
        {
        }

        public void mute() {
            Console.WriteLine("El control avanzado esta muteando el dispositivo " + device.GetType().Name);
            this.device.setVolume(0);
            Console.WriteLine("volumen: " + device.getVolume());
        }
    }
}
