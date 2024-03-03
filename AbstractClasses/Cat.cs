namespace AbstractClasses
{
    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
        }

        public override void Say()
        {
            System.Console.WriteLine("Meow!");
        }
    }
}