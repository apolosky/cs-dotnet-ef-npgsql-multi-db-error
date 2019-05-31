using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;

namespace da2.Context
{
    public partial class DA2Context : DbContext
    {
        public string Connection;

        static DA2Context()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Enums.CustomType2>("db2.custom_type_2");
        }

        public DA2Context()
        {
        }

        public DA2Context(DbContextOptions<DA2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Table2> Table2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForNpgsqlHasEnum("db2", "custom_type_2", new[] { "asdf", "zxcv", "wer" })
                .HasPostgresExtension("uuid-ossp")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Models.Table2>(entity =>
            {
                entity.ToTable("table_2", "db2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.IdFromTable1).HasColumnName("id_from_table_1");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom");
            });
        }
    }
}
