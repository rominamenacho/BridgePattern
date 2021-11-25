using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Tv : IDevice
    {
        int volumen, _channel;
        bool _enable;



        public void disable()
        {
            _enable = false;
        }

        public void enable()
        {
            _enable = true;
        }

        public int getChannel()
        {
            return _channel;
        }

        public int getVolume()
        {
            return volumen;
        }

        public bool isEnabled()
        {
           return _enable;
        }

      
        public void setChannel(int channel)
        {
            _channel = channel;
        }

        public void setVolume(int value)
        {
            volumen = value;
        }

      
    }
}
