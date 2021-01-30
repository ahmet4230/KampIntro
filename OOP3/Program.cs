using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiacKrediManager = new İhtiacKrediManager();          
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();    
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggarService = new FileLoggerService();
            //
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            //
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
            
               

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiacKrediManager , taşıtKrediManager , konutKrediManager };
            //basvuruManager.KrediÖnBilgilendirmesiYap(krediler);
          
        }
    }
}
