
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice dispositivo = new Tv();
            dispositivo.setChannel(740);
            dispositivo.setVolume(43);
            dispositivo.enable();

            Remote remote = new Remote(dispositivo);//bridge
            remote.togglePower();
            remote.volumeUp();

            dispositivo = new Radio();

            AdvancedRemote remoteAd = new AdvancedRemote(dispositivo);
            remoteAd.mute();

            Console.ReadKey();
        }
    }
}
