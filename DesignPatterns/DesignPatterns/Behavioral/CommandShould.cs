using Command.Commands;
using Command.Interfaces.Receivers;
using Command.Invokers;
using Command.Models;
using Command.Receivers;
using NUnit.Framework;

namespace DesignPatterns.Behavioral
{
    public class CommandShould
    {
        private CommandInvoker? invoker;
        private IEmployeeManagerReceiver? receiver;

        [SetUp()]
        public void SetUp()
        {
            invoker = new CommandInvoker { };
            receiver = new EmployeeManagerReceiver { };
        }

        [TearDown()]
        public void TearDown() 
        {
            invoker = null;
            receiver = null;
        }

        [Test()]
        public void Execute()
        {
#pragma warning disable CS8604 // Possible null reference argument.
            invoker?.Invoke(
                new EmployeeCommand(
                    1, new Employee(1, "ROBERT MCLIAM WILSON"), receiver));
            invoker?.Invoke(
                new EmployeeCommand(
                    1, new Employee(2, "JOHN B. KEANE"), receiver));
            invoker?.Invoke(
                new EmployeeCommand(
                    2, new Employee(3, "PATRICK MCCABE"), receiver));
#pragma warning restore CS8604 // Possible null reference argument.

            Assert.AreEqual(receiver?.WriteDataStore(), 
                "MANAGER 1, JAMES JOYCE EMPLOYEE 1, ROBERT MCLIAM WILSON EMPLOYEE 2, JOHN B. KEANE MANAGER 2, FLANN O'BRIEN EMPLOYEE 3, PATRICK MCCABE");
        }
    }
}
