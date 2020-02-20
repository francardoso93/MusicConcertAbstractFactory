namespace MusicConcertFactory {
    public class BossaNovaBandFactory : BandFactory {
        public override PercursionInstrument CreatePercursionInstrument () {
            return new Drums ();
        }

        public override StringInstrument CreateStringInstrument () {
            return new AcousticGuitar ();
        }
    }
}