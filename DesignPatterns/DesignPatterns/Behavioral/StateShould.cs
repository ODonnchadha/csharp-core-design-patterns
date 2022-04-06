using NUnit.Framework;
using State.Models;
using State.States;

namespace DesignPatterns.Behavioral
{
    public class StateShould
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        BankAccount account;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [SetUp()]
        public void SetUp() => account = new BankAccount { };

        [TearDown()]
        public void TearDown()
        {
        }

        [Test()]
        public void TransitionToOverdrawnState()
        {
            account.Deposit(40);
            Assert.IsInstanceOf<RegularState>(account.BankAccountState);

            account.Withdraw(81);
            Assert.IsInstanceOf<OverdrawnState>(account.BankAccountState);

            account.Withdraw(1000000);
            Assert.AreEqual(account.Balance, -1);
        }

        [Test()]
        public void TransitionToGoldState()
        {
            account.Withdraw(81);
            Assert.IsInstanceOf<OverdrawnState>(account.BankAccountState);

            account.Deposit(1081);
            Assert.IsInstanceOf<RegularState>(account.BankAccountState);

            account.Deposit(0);
            Assert.IsInstanceOf<GoldState>(account.BankAccountState);

            Assert.AreEqual(account.Balance, 1040);

            account.Withdraw(41);
            Assert.IsInstanceOf<RegularState>(account.BankAccountState);
        }
    }
}
