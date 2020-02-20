using System;

namespace MusicConcertFactory {
    public class Concert {
        private readonly StringInstrument stringInstrument;
        private readonly PercursionInstrument percursionInstrument;
        public Concert (BandFactory bandFactory) {
            stringInstrument = bandFactory.CreateStringInstrument ();
            percursionInstrument = bandFactory.CreatePercursionInstrument ();
        }

        public void StartShow () {
            percursionInstrument.Play ();
            stringInstrument.Play ();
        }
    }
}