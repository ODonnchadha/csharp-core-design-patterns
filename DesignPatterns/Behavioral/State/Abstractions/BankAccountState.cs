using State.Models;

namespace State.Abstractions
{
    /// <summary>
    /// State.
    /// </summary>
    public abstract class BankAccountState
    {
        public BankAccount BankAccount { get; protected set; } = null!;
        public decimal Balance { get; protected set; } 
        public abstract void Deposit(decimal amt);
        public abstract void Withdraw(decimal amt);
    }
}
