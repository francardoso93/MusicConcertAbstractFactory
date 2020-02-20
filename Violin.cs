using System;

namespace MusicConcertFactory {
    public class Violin : StringInstrument {
        public override void Play () {
            Console.WriteLine ("tiririririri");

        }
        public override void ReplaceStrings () {
             Console.WriteLine ("Old violin strings replaced by new");
        }

        public override void Tune () {
            Console.WriteLine ("Violin is now tunned");
        }
    }
}