﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new
                FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager> {ıhtiyacKrediManager,konutKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
