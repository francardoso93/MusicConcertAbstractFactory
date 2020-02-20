using System;

namespace MusicConcertFactory {
    public class Drums : PercursionInstrument {
        public override void Play () {
            Console.WriteLine ("ba dum psss");
        }

        public override void Tune () {
            Console.WriteLine ("Drums is now tunned");
        }
    }
}