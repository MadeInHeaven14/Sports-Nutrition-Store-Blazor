namespace Sports_Nutrition_Store_Blazor.Data
{
    public class UserService
    {
        public string Login = string.Empty;
        public string Email = string.Empty;
        public string Password = string.Empty;
        public float Balance;
        public string Role  = string.Empty;
        public List<Product> Basket = new List<Product>();
        public List<Product> Purchases = new List<Product>();

        public void SignIn(User user)
        {
            Login = user.Login;
            Email = user.Email;
            Password = user.Password;
            Basket = user.Basket;
            Role = user.Role;
            Balance = user.Balance;
            Purchases = user.Purchases;
            return;
        }

        public void LogOut()
        {
            Login = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Basket = new List<Product>();
            Role = string.Empty;
            Balance = 0;
            Purchases = new List<Product>();
            return;
        }
    }
}
