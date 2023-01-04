using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Text.Json;

namespace HearthstoneInsertData;

public class MongoService
{

    private readonly MongoClient _client;

    public MongoService()
    {
        _client = new MongoClient("mongodb://localhost:27017");

        var db = _client.GetDatabase("Hearthstone");

        if (_client.GetDatabase("Hearthstone").ListCollections().ToList().Count == 0)
        {

            var collection = db.GetCollection<Card>("cards");

            foreach (var path in new[] { "lea.json", "arn.json", "atq.json", "leg.json" })
            {
                using (var file = new StreamReader(path))
                {
                    var cards = JsonSerializer.Deserialize<List<Card>>(file.ReadToEnd(), new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    collection.InsertMany(cards);
                }
            }
        }
    }

    public MongoClient Client
    {
        get
        {
            return _client;
        }
    }
}
