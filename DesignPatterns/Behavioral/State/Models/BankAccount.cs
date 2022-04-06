using State.Abstractions;
using State.States;

namespace State.Models
{
    /// <summary>
    /// Context.
    /// </summary>
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance
        {
            get
            {
                return BankAccountState.Balance;
            }
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BankAccount()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            BankAccountState = new RegularState(40, this);
        }
        public void Deposit(decimal amt) => BankAccountState.Deposit(amt);
        public void Withdraw(decimal amt) => BankAccountState.Withdraw(amt);
    }
}
