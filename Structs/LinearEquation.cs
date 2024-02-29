namespace Structs
{
    internal struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public double Root()
        {
            return -this.b / this.k;
        }
    }
}