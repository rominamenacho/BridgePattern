using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //esta clase deberia tener caract propias del dispositivo, a fines practicos es igual a tv
    class Radio : IDevice
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
            setDial(channel);
        }

        public void setVolume(int value)
        {
            volumen = value;
        }

        private void setDial(int value) { 
         _channel = value;
        }
    }
}
