using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Persistance.context;
using System.ComponentModel.Design;

namespace OnlineMuhasebeServer.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";

        public CompanyDbContext( string companyId , Company company = null)
        {
            
            if(company != null)
            {
                if (company.UserId == null)
                {
                    //For Local
                    ConnectionString = $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DataBaseName};" +
                    $"Integrated Security=True;" +
                    $"Connect Timeout=30;Encrypt=False;" +
                    $"Trust Server Certificate=False;" +
                    $"Application Intent=ReadWrite;" +
                    $"Multi Subnet Failover=False";
                }
                else
                {
                    ConnectionString = $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DataBaseName};" +
                    $"User Id= {company.UserId};" +
                    $"Password = {company.Passworld};" +
                    $"Integrated Security=True;" +
                    $"Connect Timeout=30;Encrypt=False;" +
                    $"Trust Server Certificate=False;" +
                    $"Application Intent=ReadWrite;" +
                    $"Multi Subnet Failover=False";
                }
            }           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReferance).Assembly);


        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext("");
            }
        }
    }
}
