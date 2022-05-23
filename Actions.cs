using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Actions
    {
        private BusinessException _businessException = new BusinessException("Skipped logic in method");
        private Exception _exception = new Exception("I broke a logic");

        public Result Info()
        {
            return new Result(LogLevel.Info,  "Start method: ", DateTime.Now);
        }

        public Result Warning()
        {
            return new Result(LogLevel.Warning, _businessException, DateTime.Now);
        }

        public Result Error()
        {
            return new Result(LogLevel.Error, _exception, DateTime.Now);
        }
    }
}
