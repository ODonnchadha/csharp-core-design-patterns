using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;
using NUnit.Framework;
using System;
using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Behavioral
{
    public class ChainOfResponsibilityShould
    {
        DocumentTitleHandler handler1 = new DocumentTitleHandler();
        DocumentLastModifiedHandler handler2 = new DocumentLastModifiedHandler();
        DocumentApprovedByLitigationHandler handler3 = new DocumentApprovedByLitigationHandler();
        DocumentApprovedByManagementHandler handler4 = new DocumentApprovedByManagementHandler();

        [SetUp()]
        public void SetUp()
        {
            handler1.SetSuccessor(
                handler2.SetSuccessor(
                    handler3.SetSuccessor(handler4)));
        }

        [TearDown()]
        public void TearDown()
        {
        }

        [Test()]
        public void Validate()
        {
            var d = new Document("T", DateTimeOffset.UtcNow, true, true);
            Action a = () => handler1.Handle(d);
            a.Invoke();
        }

        [Test()]
        public void Invalidate()
        {
            var d = new Document("T", DateTimeOffset.UtcNow, true, false);
            Action a = () => handler1.Handle(d);

            Assert.Throws<ValidationException>(() => a.Invoke());
        }
    }
}
