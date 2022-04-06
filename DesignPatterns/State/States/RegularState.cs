using State.Abstractions;
using State.Models;

namespace State.States
{
    /// <summary>
    /// Concrete State.
    /// </summary>
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount account)
        {
            Balance = balance;
            BankAccount = account;
        }
        public override void Deposit(decimal amt) => Balance += amt;
        public override void Withdraw(decimal amt)
        {
            Balance -= amt;

            if (Balance < 0)
            {
                BankAccount.BankAccountState = 
                    new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
