using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public class Remote
    {
        protected IDevice device;//bridge

        public Remote(IDevice _device)
        {
            device = _device;//bridge
        }

        public void togglePower() {
            Console.WriteLine("device antes. enable?: "+ device.isEnabled());
            if (device.isEnabled())
            {
                device.disable();
            }
            else
            {
                device.enable();
            }
            Console.WriteLine("device desp. enable?: "+ device.isEnabled());

        }
        public  void volumeDown() {
            Console.WriteLine("volumen antes: " + device.getVolume());

            device.setVolume(device.getVolume() - 10);
            Console.WriteLine("volumen despues: " + device.getVolume());

        }
        public  void volumeUp() {
            Console.WriteLine("volumen antes: " + device.getVolume());

            device.setVolume(device.getVolume() + 10);
            Console.WriteLine("volumen despues: " + device.getVolume());

        }
        public  void channelDown() {
            Console.WriteLine("canal antes: " + device.getChannel());

            device.setChannel(device.getChannel() - 1);
            Console.WriteLine("canal despues: " + device.getChannel());

        }
        public  void channelUp() {
            Console.WriteLine("canal antes: "+ device.getChannel());
            device.setChannel(device.getChannel() + 1);
            Console.WriteLine("canal despues: " + device.getChannel());


        }

    }
}
