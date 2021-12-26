using System;
using System.Collections.Generic;
using System.Text;

namespace NewWorldCooldownTracker
{
    public interface ICooldown
    {
        TimeSpan GetRemainingTime();
        DateTime GetEndTime();
        void SetActive();
        void SetActive(int elapsedMinutes);
        bool IsActive();
    }
}
