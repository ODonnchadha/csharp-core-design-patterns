using State.Abstractions;
using State.Models;

namespace State.States
{
    public class OverdrawnState : BankAccountState
    {
        public OverdrawnState(decimal balance, BankAccount account)
        {
            Balance = balance;
            BankAccount = account;
        }
        public override void Deposit(decimal amt)
        {
            Balance += amt;

            if (Balance >= 0)
            {
                BankAccount.BankAccountState =
                    new RegularState(Balance, BankAccount);
            }
        }
        public override void Withdraw(decimal amt) { }
    }
}
