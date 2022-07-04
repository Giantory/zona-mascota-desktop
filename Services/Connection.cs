namespace Services
{
    public abstract class Connection
    {
        public string stringConnection { get; set; }

        public string message { get; set; }

        public int status { get; set; }

        public Connection()
        {
            stringConnection = @"Data Source=localhost;Initial Catalog=ZONAMASCOTA;User ID=sa;Password=sql";
        }
    }
}