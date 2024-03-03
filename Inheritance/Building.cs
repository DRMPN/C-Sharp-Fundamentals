namespace Inheritance
{
    class Building
    {
        string Address { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set; }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"Address: {Address}, L: {Length}, W: {Width}, H: {Height}";
        }
    }
}