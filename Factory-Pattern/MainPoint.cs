using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    /// <summary>
    /// 和IFactory ，两种方式来实现接口工厂 
    /// </summary>
    public abstract class LoggerFacotry
    {
        public abstract ILogger createLogger();

        /// <summary>
        /// 隐藏工厂方法
        /// </summary>
        public void WirteLog()
        {
            ILogger logger = this.createLogger();
            logger.WriteLogger();
        }

    }

    class MainPoint
    {
        static void Main(string[] args)
        {
            IFactory ifactory;
            LoggerFacotry ifactory1;
            ILogger iLog;

            //1.直接调用
            //ifactory = new DatabaseLoggerFactory();

            //2.通过反射，来实现配置来决定生成那个模式
            ifactory = (IFactory)Assembly.Load("Factory-Pattern").CreateInstance("Factory_Pattern.FileLoggerFactory");
            iLog = ifactory.LoggerFactory();
            iLog.WriteLogger();

            ifactory1 = (LoggerFacotry)Assembly.Load("Factory-Pattern").CreateInstance("Factory_Pattern.OtherLoggerFactory");
            ifactory1.WirteLog();

          
            Console.Read();
        }
    }
}
