using AstroApi.Controllers;
using AstroApi.Utils;
using Microsoft.Extensions.ObjectPool;
using Npgsql;

namespace AstroApi.DbControllers;

public class DbController
{
    ConfigurationVariablesController configurationVariables =
        new ConfigurationVariablesController();

    public bool isInititiated;
    public Task<NpgsqlDataSource> database { get; }

    public DbController()
    {
        database = InitiateDb();
    }

    public async Task<NpgsqlDataSource> InitiateDb()
    {
        await using var dataSource = NpgsqlDataSource.Create(
            configurationVariables.GetVariable("ConnectionStrings:uri")
        );
        isInititiated = true;
        return dataSource;
    }

    public async Task CreateDbTables()
    {
        // await using (var cmd = dataSource.CreateCommand("SELECT some_field FROM data"))    //
        return;
    }

    public async Task LoginUser(string email, string password)
    {
        if (isInititiated)
        {
            try
            {
                bool userExist = false;

                await using var dataSource = NpgsqlDataSource.Create(
                    configurationVariables.GetVariable("ConnectionStrings:uri")
                );
                var initial = new NpgsqlCommand(
                    "select count(*) from user_login ul where ul.email = $1",
                    dataSource.OpenConnection()
                )
                {
                    Parameters = { new() { Value = email }, }
                };

                await using var readerinit = await initial.ExecuteReaderAsync();

                while (await readerinit.ReadAsync())
                {
                    userExist = (long)readerinit["count"] != 0;
                }

                if (userExist)
                {
                    var cmd = new NpgsqlCommand(
                        "select * from public.user left join user_data ud ON user_data_id = ud.id",
                        dataSource.OpenConnection()
                    );

                    await using var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        List<Dictionary<string, dynamic>> result =
                            await Utils.Utils.ConvertDataReaderToDictionaryList(reader);

                        Console.WriteLine(result[0]);

                        foreach (var kvp in result[0])
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }

            // var cmd = local.CreateCommand("SELECT * from 'user'");

            // // cmd.Parameters.AddWithValue("Hello world");
            // await cmd.ExecuteNonQueryAsync();
            // var dat = cmd.ExecuteReader();
            // Console.WriteLine(dat);
        }
        return;
    }
}
