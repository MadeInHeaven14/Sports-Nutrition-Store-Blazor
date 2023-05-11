using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public class Product
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [Required(ErrorMessage = "Пожалуйста, введите название товара")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите цену товара")]
        public float Price { get; set; }
        public string Img { get; set; }
    }
}
