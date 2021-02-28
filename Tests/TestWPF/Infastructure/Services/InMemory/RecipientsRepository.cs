using System.Linq;
using WpfMailSender.Models;

namespace WpfMailSender.Infastructure.Services.InMemory
{
    class RecipientsRepository : RepositoryInMemory<Recipent>
    {

        public RecipientsRepository() : base(Enumerable.Range(1, 10).Select(i => new Recipent
        {
            Id = i,
            Name = $"Имя-{i}",
            Address = $"recipient{i}@server.com",

        }))
        {
        }

        public override void Update(Recipent item)
        {
            var db_item = GetById(item.Id);
            if (db_item is null || ReferenceEquals(db_item, item)) return;

            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }
    }
}