using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [Required(ErrorMessage = "Пожалуйста, введите логин")]
        //[StringLength(10, MinimumLength = 4, ErrorMessage = "Введите корректный логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите почту")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите пароль")]
        //[StringLength(15, MinimumLength = 6, ErrorMessage = "Введите корректный пароль")]
        public string Password { get; set; }
        public string Role { get; set; }
        [BsonIgnoreIfNull]
        public float Balance { get; set; }
        [BsonIgnoreIfNull]
        public List<Product>? Basket { get; set; }
        [BsonIgnoreIfNull]
        public List<Product>? Purchases { get; set; }
        [BsonIgnoreIfNull]
        public string? FIO { get; set; }
        [BsonIgnoreIfNull]
        public string? PlaceOfWork { get; set; }
    }
}
