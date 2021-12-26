using System;
using System.Collections.Generic;

namespace NewWorldCooldownTracker
{
    public class Tracker
    {
        private ILogger _logger;
        private PersistenceDataService _dataService;
        private List<ICooldown> _cooldowns;

        public Tracker(ILogger logger)
        {
            _logger = logger;
            _logger.Log("Initializing tracker");

            LoadOrCreateFile();
        }

        private void LoadOrCreateFile()
        {
            if(_dataService.PreviousDataExists())
            {
                _cooldowns = _dataService.Load();
            }
            else
            {
                _cooldowns = InitializeAllCooldowns();
            }
        }

        private List<ICooldown> InitializeAllCooldowns()
        {
            CooldownFactory factory = new CooldownFactory();
            return factory.Create();
        }
    }
}
