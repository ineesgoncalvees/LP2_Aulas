using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDecorations
{
    class MachineGun : Gun
    {
        public override int AmmoCapacity { get; } = 10;
        public override float NoiseLevel { get; } = 5;

        public override string Render()
        {
            return "MachineGun";
        }
    }
}
