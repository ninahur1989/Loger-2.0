using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    internal sealed class Logger
    {
        private static Logger instance = null;
        private Logger()
        {
            Results = new List<Result>();
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        private List<Result> Results { get; set; }

        public void Addlog(Result result)
        {
            Results.Add(result);
        }

        public void Show()
        {
            string[] logs = new string[10];
            int i = 0;
            FileService fileService = new FileService();
            foreach (Result result in Results)
            {
                string msg, log;
                if (result.Status == LogLevel.Error)
                {
                    msg = "Action failed by a reason: ";
                    log = $" время: {result.DateTime} тип {result.Status} сообщение {msg}{result.Exception.GetType()} c результатом {result.Exception.Message}";
                }
                else if (result.Status == LogLevel.Warning)
                {
                    msg = "Action got this custom Exception ";
                    log = $" время: {result.DateTime} тип {result.Status} сообщение {msg}{result.Exception.GetType()} c результатом {result.Exception.Message}";
                }
                else
                {
                    log = $" время: {result.DateTime} тип {result.Status} сообщение  {result.Message}";
                }

                logs[i] = log;
                i++;
            }

            fileService.FileWriter(logs);
        }
    }
}
