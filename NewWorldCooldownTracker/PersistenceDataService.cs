using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace NewWorldCooldownTracker
{
    internal class PersistenceDataService
    {
        private const string _dataLocation = @".\data.json";
        private ILogger _logger;

        public PersistenceDataService(ILogger logger)
        {
            _logger = logger;
        }

        public bool PreviousDataExists()
        {
            return File.Exists(_dataLocation);
        }

        public List<ICooldown> Load()
        {
            try
            {
                string content = File.ReadAllText(_dataLocation);
                return JsonConvert.DeserializeObject<List<ICooldown>>(content);
            }
            catch (System.Exception ex)
            {
                _logger.Log($"Error loading data.json, this may be due to corrupted data or access rights.\nError: {ex.Message}");
                _logger.Log("Shutting down in 5 seconds...");
                Thread.Sleep(5000);
                Environment.Exit(-1);
                return null;
            }
        }

        public void Save(List<ICooldown> cooldowns)
        {
            string content = JsonConvert.SerializeObject(cooldowns);
            File.WriteAllText(_dataLocation, content);
        }
    }
}