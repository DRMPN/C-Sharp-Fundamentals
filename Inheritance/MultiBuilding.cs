namespace Inheritance
{
    sealed class MultiBuilding:Building
    {
        int Floors { get; set; }

        public MultiBuilding(string address, double length, double width, double height, int floors) :base(address, length, width, height)
        {
            Floors = floors;
        }

        public string Print()
        {
            return base.Print() + $", Floors: {Floors}";
        }
    }
}