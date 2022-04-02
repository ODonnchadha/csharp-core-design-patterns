using Mediator.Mediators;
using Mediator.Models;
using NUnit.Framework;

namespace DesignPatterns.Behavioral
{
    public class MediatorShould
    {
        private string MESSAGE = "HELLO WORLD!";
        private Chatroom? chatroom;

        [SetUp()]
        public void SetUp() => chatroom = new();

        [TearDown()]
        public void TearDown() => chatroom = null;

        [Test()]
        public void Chat()
        {
            var lawyer1 = new Lawyer("Lawyer1");
            var lawyer2 = new Lawyer("Lawyer2");
            var scientist1 = new Lawyer("Scientist1");

            chatroom?.Register(lawyer1);
            chatroom?.Register(lawyer2);
            chatroom?.Register(scientist1);

            lawyer1.Send(MESSAGE);
            Assert.AreEqual(lawyer2.Receive("Lawyer1", MESSAGE), $"Lawyer to Lawyer2: {MESSAGE}");
            Assert.AreEqual(scientist1.Receive("Lawyer1", MESSAGE), $"Lawyer to Scientist1: {MESSAGE}");
        }
    }
}
