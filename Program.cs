using System;

namespace MusicConcertFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start a bossa nova show!");
            Concert bossaNovaConvert = new Concert(new BossaNovaBandFactory());
            bossaNovaConvert.StartShow();

            Console.WriteLine("Now it's time for some classic music!");
            Concert classicalConvert = new Concert(new ClassicalBandFactory());
            classicalConvert.StartShow();
        }
    }
}
