using AstroApi.Controllers;
using Microsoft.Extensions.ObjectPool;
using Npgsql;

namespace AstroApi.DbControllers;

public class DbController
{
    ConfigurationVariablesController configurationVariables =
        new ConfigurationVariablesController();

    public async Task LoginUser(string email, string password)
    {
        await using var dataSource = NpgsqlDataSource.Create(
            configurationVariables.GetVariable("ConnectionStrings:uri")
        );

        return;
    }
}
