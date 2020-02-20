namespace MusicConcertFactory {
    public class ClassicalBandFactory : BandFactory {
        public override PercursionInstrument CreatePercursionInstrument () {
            return new Xylophone ();
        }

        public override StringInstrument CreateStringInstrument () {
            return new Violin ();
        }
    }
}