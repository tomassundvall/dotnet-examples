using System;
using Microsoft.Extensions.Logging;

namespace DotnetExamples
{
    public interface ILoggerAdapter<T>
    {
        void Debug(string message);
        void Debug(string message, params object[] args);
        void Information(string message);
        void Information(string message, params object[] args);
        void Warning(string message);
        void Warning(string message, params object[] args);
        void Warning(Exception exception, string message);
        void Warning(Exception exception, string message, params object[] args);
        void Error(string message);
        void Error(string message, params object[] args);
        void Error(Exception exception, string message);
        void Error(Exception exception, string message, params object[] args);
        void Critical(string message);
        void Critical(string message, params object[] args);
        void Critical(Exception exception, string message);
        void Critical(Exception exception, string message, params object[] args);
    }


    public class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILogger<T> _log;


        public LoggerAdapter(ILogger<T> log)
        {
            _log = log;
        }


        public void Debug(string message)
        {
            _log.LogDebug(message);
        }


        public void Debug(
            string message,
            params object[] args)
        {
            _log.LogDebug(message, args);
        }


        public void Information(string message)
        {
            _log.LogInformation(message);
        }


        public void Information(
            string message, 
            params object[] args)
        {
            _log.LogInformation(message, args);
        }


        public void Warning(string message)
        {
            _log.LogWarning(message);
        }


        public void Warning(
            string message,
            params object[] args)
        {
            _log.LogWarning(message, args);
        }


        public void Warning(
            Exception exception,
            string message)
        {
            _log.LogWarning(exception, message);
        }


        public void Warning(
            Exception exception,
            string message,
            params object[] args)
        {
            _log.LogWarning(exception, message, args);
        }


        public void Error(string message)
        {
            _log.LogError(message);
        }


        public void Error(
            string message,
            params object[] args)
        {
            _log.LogError(message, args);
        }


        public void Error(
            Exception exception,
            string message)
        {
            _log.LogError(exception, message);
        }


        public void Error(
            Exception exception,
            string message,
            params object[] args)
        {
            _log.LogError(exception, message, args);
        }


        public void Critical(string message)
        {
            _log.LogCritical(message);
        }


        public void Critical(
            string message,
            params object[] args)
        {
            _log.LogCritical(message, args);
        }


        public void Critical(
            Exception exception,
            string message)
        {
            _log.LogCritical(exception, message);
        }


        public void Critical(
            Exception exception,
            string message,
            params object[] args)
        {
            _log.LogCritical(exception, message, args);
        }
    }
}
