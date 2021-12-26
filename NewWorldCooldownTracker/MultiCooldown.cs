using System;
using System.Collections.Generic;
using System.Text;

namespace NewWorldCooldownTracker
{
    class MultiCooldown
        : ICooldown
    {
        private string name;
        private Queue<MultiCooldownInstance> _cooldownQueue;
        private int _maxInstances;
        private TimeSpan _instanceDuraction;

        public MultiCooldown(TimeSpan instanceDuraction, int maxInstances)
        {
            _instanceDuraction = instanceDuraction;
            _maxInstances = maxInstances;
        }

        public CooldownType Type { get; private set; }
            
        public DateTime GetEndTime()
        {
            if (_cooldownQueue.Count > 0)
            {
                return _cooldownQueue.Peek().GetEndTime();
            }
            else return DateTime.Now;
           
        }

        public TimeSpan GetRemainingTime()
        {
            if (_cooldownQueue.Count > 0)
            {
                return _cooldownQueue.Peek().GetRemainingTime();
            }
            else return TimeSpan.FromSeconds(0);
        }

        public bool IsActive()
        {
            Cooldown instance;
            bool any = _cooldownQueue.TryPeek(out instance);
            return any && instance.IsActive();
        }

        public void SetActive()
        {
            throw new NotImplementedException();
        }

        private void AddInstance()
        {
            RemoveOldInstances();
            if(_cooldownQueue.Count < _maxInstances)
            {
                _cooldownQueue.Enqueue(new )
            }
        }

        private void RemoveOldInstances()
        {
            Cooldown instance;
            while(_cooldownQueue.TryPeek(out instance) && !instance.IsActive())
            {
                _cooldownQueue.Dequeue();
            }
        }

        public void SetActive(int elapsedMinutes)
        {
            throw new NotImplementedException();
        }
    }
}
