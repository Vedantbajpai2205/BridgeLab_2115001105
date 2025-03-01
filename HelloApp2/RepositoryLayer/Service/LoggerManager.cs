using Microsoft.Extensions.Logging;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class LoggerManager<T> : ILoggerManager<T>
    {
        private readonly ILogger<LoggerManager<T>> _logger;

        public LoggerManager(ILogger<LoggerManager<T>> logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogWarn(string message)
        {
            _logger.LogWarning(message);
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void LogError(string message)
        {
            _logger.LogError(message);
        }
    }
}
