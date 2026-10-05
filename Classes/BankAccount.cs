
namespace Inkapsling.Classes
{
    public class BankAccount
    {
        private double balance; // privat fält - ingen utanför klassen kan röra detta direkt

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Saldot kan inte vara negativt! Insättningen avvisades.");
                }
                else
                {
                    balance = value;
                }
            }
        }
    }
}