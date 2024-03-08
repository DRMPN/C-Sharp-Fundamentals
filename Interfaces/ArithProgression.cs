namespace Interfaces
{
    internal class ArithProgression:ISeries
    {
        int start;
        int step;
        int current;
        public ArithProgression()
        {
        }

        public void SetStep(int x)
        {
            step = x;
        }

        public int GetNext()
        {
            current += step;
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