using System;
using System.Collections.Generic;
using System.Text;

namespace NewWorldCooldownTracker
{
    public abstract class Cooldown
        : ICooldown
    {
        protected  CooldownType _cooldownType;
        protected DateTime _endTime;
        protected readonly TimeSpan _duration;

        public readonly string Name;

        public Cooldown(string name, TimeSpan duration)
        {
            Name = name;
            _duration = duration;
        }


        public virtual DateTime GetEndTime()
        {
            return _endTime;
        }

        public bool IsActive()
        {
            return GetRemainingTime().TotalMilliseconds > 0;
        }

        public virtual void SetActive()
        {
            _endTime = DateTime.Now + _duration;
        }

        public void SetActive(int elapsedMinutes)
        {
            _endTime = DateTime.Now.AddMinutes(-elapsedMinutes) + _duration;
            
        }

        public TimeSpan GetRemainingTime()
        {
            return _endTime.Subtract(DateTime.Now);
        }
    }
}
