using System;

namespace Enum_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class BankAccount
    {
        public int Balance { get; set; }
        public string BalaOwnernce { get; set; }
        public int InterestRate { get; set; }

        public void Withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount} from the account.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
            }
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount} into the account.");
        }
        public void Transfer(BankAccount destinationAccount, int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine($"Successfully transferred {amount} to {destinationAccount.OwnerName}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Transfer failed.");
            }
        }
    }
}
