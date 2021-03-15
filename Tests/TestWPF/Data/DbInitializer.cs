﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfMailSender.Data
{
    class DbInitializer
    {
        private readonly MailSenderDb _db;

        public DbInitializer(MailSenderDb db) { _db = db; }

        public async Task InitializeAsync()
        {
            await _db.Database.MigrateAsync().ConfigureAwait(false);

            if (!await _db.Senders.AnyAsync())
            {
                await _db.Senders.AddRangeAsync(TestData.Senders);
                await _db.SaveChangesAsync();
            }

            if (!await _db.Recipents.AnyAsync())
            {
                await _db.Recipents.AddRangeAsync(TestData.Recipentss);
                await _db.SaveChangesAsync();
            }

            if (!await _db.Servers.AnyAsync())
            {
                await _db.Servers.AddRangeAsync(TestData.Servers);
                await _db.SaveChangesAsync();
            }

            if (!await _db.Messages.AnyAsync())
            {
                await _db.Messages.AddRangeAsync(TestData.Messages);
                await _db.SaveChangesAsync();
            }
        }
    }
}
