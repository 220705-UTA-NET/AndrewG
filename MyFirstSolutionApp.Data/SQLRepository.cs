using System;
using MyFirstSolutionApp.Logic;
using System.Data.SqlClient;


namespace MyFirstSolutionApp.Data;
public class SQLRepository
{
    private readonly string _connectionString = "//Your connection string here";

    // the readonly modifier allows us to set a value in the constructor, then prevents modification.

    public SQLRepository(string connectionString)
        {
        this._connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

    public void Insert(Student st1)
    {
        using SqlConnection connection = new SqlConnection(this._connectionString);
    }
}

