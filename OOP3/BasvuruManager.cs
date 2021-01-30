using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)
        {
            // Başvuran kişinin bilgilerini değerlendirme için bilgi alma alanımız.

            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.log();
            }


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }



    }
}