using Microsoft.EntityFrameworkCore;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.Contexto
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<SolicitacaoLicenca> SolicitacaoLicencas { get; set; }
        public DbSet<Licenca> Licencas { get; set; }

        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Status>().Property("StatusId").IsRequired();
            //modelBuilder.Entity<Software>().HasKey("PessoaId");
            //modelBuilder.Entity<Funcionario>().HasOne(l => l.Equipe).WithOne(u => u.GestorId).HasForeignKey<Equipe>(u => u.GestorId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Projeto40; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            }
        }
    }
}