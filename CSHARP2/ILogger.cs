 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{

	public interface ILogger
	{
		void LogMessage(string message);
	}

	public class FileLogger : ILogger
	{
		private string _filePath;

		public FileLogger(string filePath)
		{
			_filePath = filePath;
		}

		public void LogMessage(string message)
		{
			File.AppendAllText(_filePath, message + Environment.NewLine);
		}
	}

	public class ConsoleLogger : ILogger
	{
		public void LogMessage(string message)
		{
			Console.WriteLine(message);
		}
	}

	public class MultiLogger
	{
		private ILogger[] _loggers;

		public MultiLogger(params ILogger[] loggers)
		{
			_loggers = loggers;
		}

		public void Log(string message)
		{
			foreach (var logger in _loggers)
			{
				logger.LogMessage(message);
			}
		}
	}

	public class LoggerController
	{
		private MultiLogger _multiLogger;
		private LoggerView _view;

		public LoggerController(MultiLogger multiLogger, LoggerView view)
		{
			_multiLogger = multiLogger;
			_view = view;
		}

		public void LogMessage(string message)
		{
			_multiLogger.Log(message);
			_view.DisplayLog(message);
		}
	}

	public class LoggerView
	{
		public void DisplayLog(string message)
		{
			Console.WriteLine($"Logged: {message}");
		}
	}
}
