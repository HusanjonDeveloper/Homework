/*

string api = "https://fakestoreapi.com/carts/5";
MyDbContext MyDbContext = new MyDbContext();

using (var client = new HttpClient())
{
    var request = await client.GetAsync(api);
    var reString = await request.Content.ReadAsStringAsync();
    JsonNamingPolicy policy = null;

    var responseModel = JsonSerializer.Deserialize<Order>(reString,
        new JsonSerializerOptions { PropertyNamingPolicy = policy });
    
        var request2 = await client.GetAsync($"https://fakestoreapi.com/carts/5");
        var reString2 = await request2.Content.ReadAsStringAsync();

        var responseModel2 = JsonSerializer.Deserialize<Order>(reString2,
            new JsonSerializerOptions { PropertyNamingPolicy = policy });

    MyDbContext.Orders.AddRange(responseModel2);
    MyDbContext.SaveChanges();
    Console.WriteLine(responseModel2);

}
*/

using System.Text.Json;
using Homework.Context;
using Homework.Models;

Product policy = new Product();
List<Order> orders = new List<Order>();
MyDbContext dBContext = new MyDbContext();

string api = "https://fakestoreapi.com/carts/5 ";

using (var client = new HttpClient())
{
    var request = await client.GetAsync(api);
    var reString = await request.Content.ReadAsStringAsync();
    var responseModel = JsonSerializer.Deserialize<Order>(reString, new JsonSerializerOptions { PropertyNamingPolicy = policy });
    for (int i = 0; i
        <= responseModel.Id; i++)
    {
        var request2 = await client.GetAsync($"https://fakestoreapi.com/carts/5{i}");
        var reString2 = await request2.Content.ReadAsStringAsync();
        var responseModel2 = JsonSerializer.Deserialize<Order>(reString2, new JsonSerializerOptions { PropertyNamingPolicy = policy });
        foreach (var item in responseModel2.Products)
        {
            orders.Add(new Order
            {
                Id = item.ProductId,
                UserId = item.ProductId,
                Date = DateTime.Now,
            });
        }
    }
}
Console.WriteLine(orders);
dBContext.Orders.AddRange(orders);
dBContext.SaveChanges();
