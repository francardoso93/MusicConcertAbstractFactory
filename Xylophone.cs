using System;

namespace MusicConcertFactory {
    public class Xylophone : PercursionInstrument {
        public override void Play () {
            Console.WriteLine ("tin tin tin");
        }

        public override void Tune () {
            Console.WriteLine ("Xylophone is now tunned");
        }
    }
}