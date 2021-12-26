using System;
using System.Collections.Generic;
using System.Text;

namespace NewWorldCooldownTracker
{
    class MultiCooldownInstance
        : Cooldown
    {
        public MultiCooldownInstance(string name, TimeSpan duration) : base(name, duration)
        {
            _cooldownType = CooldownType.MultiInstance;
        }
    }
}
