using System;
using System.Collections.Generic;

namespace NewWorldCooldownTracker
{
    internal class CooldownFactory
    {
        internal List<ICooldown> Create()
        {
            List<ICooldown> cooldowns = new List<ICooldown>();
            //Gypsum
            cooldowns.Add(new GypsumCooldown("Topaz", 7))
            //TuningOrbs
            //Materials

        }
    }
}