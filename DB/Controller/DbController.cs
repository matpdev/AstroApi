using AstroApi.Controllers;
using AstroApi.Models.User;
using AstroApi.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using Npgsql;

namespace AstroApi.DbControllers;

public class DbController : DbContext
{
    ConfigurationVariablesController configurationVariables =
        new ConfigurationVariablesController();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configurationVariables.GetVariable("ConnectionStrings:uri"));
        // base.OnConfiguring(optionsBuilder);
    }

    public virtual DbSet<UserModel> User { get; set; }
    public virtual DbSet<UserDataModel> UserData { get; set; }
    public virtual DbSet<AddressModel> Address { get; set; }
}
