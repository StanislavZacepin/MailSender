using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfMailSender.Models;

namespace WpfMailSender.Data
{
     public class MailSenderDb : DbContext
    {
        public DbSet<Sender> Senders { get; set; }

        public DbSet<Recipent> Recipents { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<SchedulerTask> Tasks {get ; set;}
        public object Recipients { get; internal set; }

        public MailSenderDb(DbContextOptions<MailSenderDb> options) : base(options)
        {

        }
    }
}
