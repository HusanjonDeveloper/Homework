using System.Text.Json;

namespace Homework.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public static implicit operator JsonNamingPolicy(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
