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
        private int JAMES = 1;
        private int FLANN = 2;

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
                    JAMES, new Employee(3, "ROBERT MCLIAM WILSON"), receiver));
            invoker?.Invoke(
                new EmployeeCommand(
                    JAMES, new Employee(4, "JOHN B. KEANE"), receiver));
            invoker?.Invoke(
                new EmployeeCommand(
                    FLANN, new Employee(5, "PATRICK MCCABE"), receiver));
#pragma warning restore CS8604 // Possible null reference argument.

            Assert.AreEqual(receiver?.Write(), 
                "MANAGER 1, JAMES JOYCE EMPLOYEE 3, ROBERT MCLIAM WILSON EMPLOYEE 4, JOHN B. KEANE MANAGER 2, FLANN O'BRIEN EMPLOYEE 5, PATRICK MCCABE");

            invoker?.Undo();
            invoker?.Undo();

            Assert.AreEqual(receiver?.Write(),
                "MANAGER 1, JAMES JOYCE EMPLOYEE 3, ROBERT MCLIAM WILSON MANAGER 2, FLANN O'BRIEN");
        }
    }
}
