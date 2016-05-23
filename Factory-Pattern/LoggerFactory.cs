using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class FileLoggerFactory:IFactory
    {
        public ILogger LoggerFactory()
        {
            ILogger item = new FileLogger();
            return item;
        }
    }

    public class DatabaseLoggerFactory : IFactory
    {
        public ILogger LoggerFactory()
        {
            ILogger item = new  DataBaseLogger();
            return item;
        }
    }
}
