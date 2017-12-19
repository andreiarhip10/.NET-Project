using System;
using Data.Data.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    public abstract class BaseIntegrationTest
    {
        protected virtual bool UseSqlServer => false;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            DestroyDatabase();
            CreateDatabase();
        }

        [TestCleanup]
        public virtual void TestCleanup()
        {
            DestroyDatabase();
        }

        protected void RunOnDatabase(Action<DatabaseService> action)
        {
            if (UseSqlServer) {
                RunOnSqlServer(action);
            }
            else
            {
                RunOnMemory(action);
            }
        }

        private void RunOnSqlServer(Action<DatabaseService> databaseAction)
        {
            var connection = @"Server = .\SQLEXPRESS; Database = DAVA.Test; Trusted_Connection = true;";
            var options = new DbContextOptionsBuilder<DatabaseService>()
                .UseSqlServer(connection)
                .Options;

            using (var context = new DatabaseService(options))
            {
                databaseAction(context);
            }
        }

        private void RunOnMemory(Action<DatabaseService> databaseAction)
        {
            var options = new DbContextOptionsBuilder<DatabaseService>()
                .UseInMemoryDatabase("ItemsList")
                .Options;

            using (var context = new DatabaseService(options))
            {
                databaseAction(context);
            }
        }

        private void CreateDatabase()
        {
            RunOnDatabase(context => context.Database.EnsureCreated());
        }

        private void DestroyDatabase()
        {
            RunOnDatabase(context => context.Database.EnsureDeleted());
        }
    }

}
