using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatebaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}