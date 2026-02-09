using Microsoft.Data.SqlClient;

public static class DbUtil
{
    // Local SQL Server (Docker / Localhost)
    private static readonly string connectionString =
        "Server=127.0.0.1,1433;" +
        "Database=HealthClinicDB;" +
        "User Id=sa;" +
        "Password=Gurjar#123;" +
        "Encrypt=False;" +
        "TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
