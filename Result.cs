using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error,
    }

    internal class Result
    {
        public Result()
        {
        }

        public Result(LogLevel status, Exception exception, DateTime dateTime)
        {
            Status = status;
            Exception = exception;
            DateTime = dateTime;
        }

        public Result(LogLevel status, string message, DateTime dateTime)
        {
            Status = status;
            Message = message;
            DateTime = dateTime;
        }

        public LogLevel Status { get; set; }
        public string Message { get; set; }

        public DateTime DateTime { get; set; }
        public Exception Exception { get; set; }
    }
}
