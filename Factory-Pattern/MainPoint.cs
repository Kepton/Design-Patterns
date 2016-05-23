using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class MainPoint
    {
        static void Main(string[] args)
        {
            IFactory ifactory;
            ILogger iLog;
            //ifactory = new DatabaseLoggerFactory();
            ifactory = (IFactory)Assembly.Load("Factory-Pattern").CreateInstance("Factory_Pattern.FileLoggerFactory");
            iLog = ifactory.LoggerFactory();
            iLog.WriteLogger();
            Console.Read();
        }
    }
}
