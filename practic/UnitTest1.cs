using NUnit.Framework;
using System;
using practic;

namespace practic
{
    [TestFixture]

    public class Tests
    {
        private Calc calculator;
        private Ticket ticket;

        [SetUp]
        public void Setup()
        {
            calculator = new Calc();
            ticket = new Ticket();
        }

        [Test]
        public void Is_lucky_ticket_1()
        {
            Assert.IsTrue(ticket.lucky_ticket("111111"));
        }

        [Test]
        public void Is_lucky_ticket_2()
        {
            Assert.IsFalse(ticket.lucky_ticket("123456"));
        }

        [Test]
        public void Is_lucky_ticket_3()
        {
            Assert.Throws<Exception>(() => ticket.lucky_ticket("12345678"));
        }
    }
}