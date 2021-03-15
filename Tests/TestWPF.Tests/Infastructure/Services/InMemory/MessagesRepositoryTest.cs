using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfMailSender.Infastructure.Services.InMemory;
using MailSender.lib.Entities;
using WpfMailSender.Models;

namespace TestWPF.Tests.Infastructure.Services.InMemory
{
    [TestClass]
    public class MessagesRepositoryTest
    { 
        [TestMethod]
        public void GetAll_Test()
        {
            var repository = new MessagesRepository();

            var all = repository.GetAll();

            Assert.IsTrue(all.Any());
        }

        [TestMethod]
        public void Add_Test()
        {
            var repository = new MessagesRepository();
            var message = new Message
            {
                Title = "Unit test message",
                Text = "Unit test text message"
            };

            var actual_id = repository.Add(message);

            var all = repository.GetAll().ToArray();

            Assert.AreEqual(actual_id, message.Id);
            CollectionAssert.Contains(all, message);
            //StringAssert.Matches();
        }
    }
}
