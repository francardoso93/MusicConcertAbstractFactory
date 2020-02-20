namespace MusicConcertFactory
{
    public abstract class BandFactory
    {
        public abstract StringInstrument CreateStringInstrument();
        public abstract PercursionInstrument CreatePercursionInstrument();
    }
}