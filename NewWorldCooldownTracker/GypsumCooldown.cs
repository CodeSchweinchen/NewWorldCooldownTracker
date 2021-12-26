using System;

namespace NewWorldCooldownTracker
{
    internal class GypsumCooldown : MultiCooldown
    {
        public GypsumCooldown(string name, int maxInstances)
            : base(new TimeSpan(18,0,0), 10)
        {
            
        }
    }
}