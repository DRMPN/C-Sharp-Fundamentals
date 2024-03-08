namespace Generics
{
    internal class BankAccount<T>
    {
        private T number;
        private double balance;
        private string fullName;

        public T Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}