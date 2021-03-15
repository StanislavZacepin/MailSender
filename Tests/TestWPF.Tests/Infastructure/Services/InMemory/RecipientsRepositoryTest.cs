using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfMailSender.Infastructure.Services.InMemory;
using MailSender.lib.Entities;
using WpfMailSender.Models;

namespace TestWPF.Tests.Infastructure.Services.InMemory
{
    [TestClass]
    public class RecipientsRepositoryTest
    {
        [TestMethod]
        public void GetAll_Test()
        {
            var repository = new RecipientsRepository();

            var all = repository.GetAll();

            Assert.IsTrue(all.Any());
        }

        [TestMethod]
        public void Add_Test()
        {
            var repository = new RecipientsRepository();
            var recipent = new Recipent
            {
                Name = "Unit test message",
                Address = "Unit test text message"
            };

            var actual_id = repository.Add(recipent);

            var all = repository.GetAll().ToArray();

            Assert.AreEqual(actual_id, recipent.Id);
            CollectionAssert.Contains(all, recipent);
            //StringAssert.Matches();
        }
    }
}