using DnsClient;
using MongoDB.Driver;
using System.Xml.Linq;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public class MongoDB
    {
        public static void AddToDB(User NewUser)
        {
            var un1t = new MongoClient();
            var database = un1t.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(NewUser);
        }

        public static User FindWithEmail (string Email)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Email == Email).FirstOrDefault();
            return one;
        }

        public static void ReplaceByEmail(User ReplaceByEmail, string Email)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Email == Email, ReplaceByEmail);
        }
    }
}
