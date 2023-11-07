namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public string? Host { get; init; }
        public int Port { get; init; }
        // caso queira testar com MongoDbAtlas basta alterar a Conection String para mongodb+srv://ruanamarallemos:vV0gvwIGu1MQYAUN@cluster0.r3poojg.mongodb.net/
        //                                                                                                  {Host}:{Port}
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }

}