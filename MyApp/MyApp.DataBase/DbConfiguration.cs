namespace MyApp.DataBase
{
    public class DbConfiguration
    {
        public ProviderType ProviderType { get; set; }

        public string SQLServerConnection { get; set; }

        public string SQLiteConnection { get; set; }
    }

    public enum ProviderType
    {
        SQLServer,
        SQLite
    }
}
