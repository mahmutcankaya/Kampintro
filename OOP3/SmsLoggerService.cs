using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class SmsLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("sms loglandi");
        }
    }
}
