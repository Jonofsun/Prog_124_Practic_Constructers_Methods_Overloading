namespace Prog_124_Practic_Constructers_Methods_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car defaultContructer = new Car();
            Car makeModleCar = new Car("Toyota", "Camery");
            Car detailedConstructer = new Car("Porche", "911 Turbo", 2000, 90600);
            Console.WriteLine(defaultContructer.ToString());
            Console.WriteLine(makeModleCar.ToString());
            Console.WriteLine(detailedConstructer.ToString());
            Console.WriteLine("\n");
            BankAccount account = new BankAccount("12313","Jonathan Reed", 20);
            Console.WriteLine(account.ToString());
            account.Deposit(500);
            Console.WriteLine(account.ToString());
            account.Deposit(-15000);
            Console.WriteLine(account.ToString());
            account.Withdraw(300);
            Console.WriteLine(account.ToString());
            account.Withdraw(-500);
            Console.WriteLine(account.ToString());

        }
    }
}