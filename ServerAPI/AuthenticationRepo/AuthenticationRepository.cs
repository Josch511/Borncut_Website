namespace ServerAPI.AuthenticationRepo
{
    public class AuthenticationRepository
    {
        public readonly IMongoDatabase db;

        public AuthenticationRepository(IConfiguration configuration)
        {
            var connectionString = configuration["Mongo:ConnectionString"];
            var client = new MongoClient(connectionString);
            db = client.GetDatabase("eksamensprojekt");
        }
    }
}
