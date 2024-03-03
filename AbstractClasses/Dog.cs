namespace AbstractClasses
{
    internal class Dog:Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Say()
        {
            System.Console.WriteLine("Woof!");
        }
    }
}