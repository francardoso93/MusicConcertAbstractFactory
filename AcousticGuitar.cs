using System;

namespace MusicConcertFactory {
    public class AcousticGuitar : StringInstrument {
        public override void Play () {
            Console.WriteLine ("dram dram dram");
        }

        public override void ReplaceStrings () {
            Console.WriteLine ("Old AcousticGuitar strings replaced by new");

        }

        public override void Tune () {
            Console.WriteLine ("AcousticGuitar is now tunned");

        }
    }
}