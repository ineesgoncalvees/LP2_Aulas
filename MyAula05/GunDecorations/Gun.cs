using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDecorations
{
    abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire()
        {
            Console.WriteLine(AmmoCapacity);
            Console.WriteLine(NoiseLevel);
        }

        public abstract string Render();
    }
}
