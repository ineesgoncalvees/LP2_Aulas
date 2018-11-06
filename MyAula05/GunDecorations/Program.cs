using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun machineGun = new MachineGun();
            Gun shotGun = new ShotGun();

            machineGun.Fire();
            shotGun.Fire();

            machineGun.Render();
            shotGun.Render();

        }
    }
}
