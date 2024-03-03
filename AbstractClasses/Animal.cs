namespace AbstractClasses
{
    abstract class Animal
    {
        string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();
       
        public void ShowInfo() {
            System.Console.WriteLine($"Name: {Name}");
            Say();
        }
    }
}