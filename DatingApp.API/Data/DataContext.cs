using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using RestSharp;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}


        public void TestMethod()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");

            var request = new RestRequest("/posts", Method.GET);

            var content = client.Execute(request).Content;

        }

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users {get; set;}
    }
}