namespace Interfaces
{
    internal class GeomProgression:ISeries
    {
        
        int start;
        int step;
        int current;

        public GeomProgression()
        {
        }

        public void SetStep(int x)
        {
            step = x;
        }

        public int GetNext()
        {
            current *= step;
            return current;
        }

        public void Reset()
        {
            current = start;
        }

        public void SetStart(int x)
        {
            start = x;
            current = start;
        }
    }
}