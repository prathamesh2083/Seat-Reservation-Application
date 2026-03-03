using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
namespace BookMySeat.Infrastructure.Database;

public class DapperDbContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public DapperDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DbConnectionString");
    }

    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);

    // Multiple Records
    public async Task<IEnumerable<T>> QueryAsync<T>(string query, object? parameters = null)
    {
        using var connection = CreateConnection();
        return await connection.QueryAsync<T>(query, parameters);
    }

    // GET Single Record
    public async Task<T?> QuerySingleOrDefaultAsync<T>(string query, object? parameters = null)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleOrDefaultAsync<T>(query, parameters);
    }

    // INSERT / UPDATE / DELETE
    public async Task<int> ExecuteAsync(string query, object? parameters = null)
    {
        using var connection = CreateConnection();
        return await connection.ExecuteAsync(query, parameters);
    }
}
