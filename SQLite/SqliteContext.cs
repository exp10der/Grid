using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using SQLite;

namespace SQliteEF6
{
    class SqliteContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        private string _dbPath;

        public SqliteContext(string path)
            : base(new SQLiteConnection
            {
                ConnectionString = new SQLiteConnectionStringBuilder
                {
                    DataSource = path,
                    ForeignKeys = true,
                    BinaryGUID = false,
                }.ConnectionString
            }, true)
        {
            _dbPath = path;
            Database.Log = Console.Write;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new SqliteContextInitializer<SqliteContext>(_dbPath, modelBuilder));
        }
    }

}