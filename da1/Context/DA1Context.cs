using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;

namespace da1.Context
{
    public partial class DA1Context : DbContext
    {
        public string Connection;

        static DA1Context()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Enums.CustomType1>("custom_type_1");
        }

        public DA1Context()
        {
        }

        public DA1Context(DbContextOptions<DA1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Table1> Table1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForNpgsqlHasEnum(null, "custom_type_1", new[] { "fizz", "buzz" })
                .HasPostgresExtension("uuid-ossp")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Models.Table1>(entity =>
            {
                entity.ToTable("table_1", "db1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('db1.table_1_id_seq'::regclass)");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom");
            });

            modelBuilder.HasSequence<int>("table_1_id_seq");
        }
    }
}
