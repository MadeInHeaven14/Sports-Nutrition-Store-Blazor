using DnsClient;
using MongoDB.Driver;
using System.Xml.Linq;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public class MongoDB
    {
        public static void AddUserToDB(User NewUser)
        {
            var unit = new MongoClient();
            var database = unit.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(NewUser);
        }

        public static void AddProductToDB(Product NewProduct)
        {
            var unit = new MongoClient();
            var database = unit.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<Product>("Products");
            collection.InsertOne(NewProduct);
        }

        public static List<Product> GetAllProduct()
        {
            var unit = new MongoClient();
            var database = unit.GetDatabase("SportNutritionUsers");
            var collection = database.GetCollection<Product>("Products");
            var Products = collection.Find(FilterDefinition<Product>.Empty).ToList();
            return Products;
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
