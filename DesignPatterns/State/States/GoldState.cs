using State.Abstractions;
using State.Models;

namespace State.States
{
    public class GoldState : BankAccountState
    {
        public GoldState(decimal balance, BankAccount account)
        {
            Balance = balance;
            BankAccount = account;
        }
        /// <summary>
        /// Adding an additional 10% as a GoldState bonus.
        /// </summary>
        /// <param name="amt"></param>
        public override void Deposit(decimal amt) => Balance += amt + (amt / 10);
        public override void Withdraw(decimal amt) 
        {
            Balance -= amt;

            if (Balance < 1000 && Balance >= 0)
            {
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
            else if (Balance < 0)
            {
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
