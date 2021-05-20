using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurslar kurs1 = new Kurslar();
            kurs1.KursAdi = "C#";
            kurs1.KursAciklama = "Başlangıç ve İleri Seviye";
            kurs1.Egitmen = "Tayfun Temurtaş";
            kurs1.IzlenmeOrani = 60;

            Kurslar kurs2 = new Kurslar();
            kurs2.KursAdi = "Java";
            kurs2.KursAciklama = "Başlangıç ve İleri Seviye";
            kurs2.Egitmen = "Ferdi Temurtaş";
            kurs2.IzlenmeOrani = 60;

            Kurslar kurs3 = new Kurslar();
            kurs3.KursAdi = "Python";
            kurs3.KursAciklama = "Başlangıç ve İleri Seviye";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 60;

            //Console.WriteLine(kurs1.KursAdi + " " +kurs1.Egitmen);

            Kurslar[] KursList = new Kurslar[] { kurs1, kurs2, kurs3 };

            foreach (Kurslar kurs in KursList)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }
        }
    }
    class Kurslar
    {
        public string KursAdi;
        public string KursAciklama;
        public string Egitmen;
        public int IzlenmeOrani;
    }
}
