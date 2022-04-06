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

        /// <summary>
        /// NOTE: We cannot transition from OverdrawnState to GoldState directly.
        /// </summary>
        /// <param name="amt"></param>
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
