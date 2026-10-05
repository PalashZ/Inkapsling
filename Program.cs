using Inkapsling.Classes;

namespace Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount konto = new BankAccount();

            Console.WriteLine("Hur mycket vill du sätta in?");
            double insattning = Convert.ToDouble(Console.ReadLine());

            konto.Balance = konto.Balance + insattning; // går via setter, som kollar negativt värde

            Console.WriteLine("Nytt saldo: " + konto.Balance);
        }
    }
}

