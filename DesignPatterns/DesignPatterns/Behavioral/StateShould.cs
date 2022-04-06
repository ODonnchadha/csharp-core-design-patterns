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
        public void Update()
        {
            account.Deposit(40);
            Assert.IsInstanceOf<RegularState>(account.BankAccountState);
            account.Withdraw(81);
            Assert.IsInstanceOf<OverdrawnState>(account.BankAccountState);
        }
    }
}
