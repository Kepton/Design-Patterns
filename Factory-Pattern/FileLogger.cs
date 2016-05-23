using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class FileLogger:ILogger
    {
        public void WriteLogger()
        {
            Console.WriteLine("FileLogger");
        }
    }

    public class DataBaseLogger : ILogger
    {
        public void WriteLogger()
        {
            Console.WriteLine("DataBaseLogger");
        }
    }


}
