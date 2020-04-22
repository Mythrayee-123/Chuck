using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckJokes.Models
{
    public class MockRepositoryCategory : ICategoryRepository
    {
       

        public IEnumerable<Category> GetAllCategories()
        {
            return GetAllCategoriesUsingApi();
        }

        private IEnumerable<Category> GetAllCategoriesUsingApi()
        {
            string url = "https://api.chucknorris.io/jokes/categories";
            var client = new System.Net.WebClient();
            var content = client.DownloadString(url);
            var jsonformattedData = JsonConvert.DeserializeObject<List<string>>(content);
            int i = 0;
            var list = new List<Category>();

            jsonformattedData.ToList().ForEach(t =>
            {
                list.Add(new Category() { Id = i + 1, Items = t });
            });

            return list;
        }

        public string GetJokeByCategory(string categoryId)
        {
            string url = $@"https://api.chucknorris.io/jokes/random?category={categoryId}";
            var client = new System.Net.WebClient();
            var content = client.DownloadString(url);
            dynamic jsonFormattedData = JsonConvert.DeserializeObject(content);
            return jsonFormattedData.value;
        }
        public Category GetCategory(int Id)
        {
            return new Category();
        }

        public Category GetCategory(string category)
        {
            var data = new Category() { Id = 1, Items = category };
            data.Joke = GetJokeByCategory(category);

            return data;
        }

       public string GetJokeSearch(string SearchTerm)
        {
            if (string.IsNullOrEmpty(SearchTerm))
            {
                SearchTerm = "Vacation";
            }
            string url = $@"https://api.chucknorris.io/jokes/search?query={SearchTerm}";
            var client = new System.Net.WebClient();
            var content = client.DownloadString(url);
            dynamic jsonFormattedData = JsonConvert.DeserializeObject(content);
            return jsonFormattedData.result[0].value.Value;
        }
       
        public Category GetJokes(string SearchTerm, string category)
        {
            var data = new Category() {Joke= SearchTerm, Items = category };
            data.Joke = GetJokeSearch(SearchTerm);

            return data;
        }
      
        public string GetRandomJokes()
        {
            string url = $@"https://api.chucknorris.io/jokes/random";
            var client = new System.Net.WebClient();
            var content = client.DownloadString(url);
            dynamic jsonFormattedData = JsonConvert.DeserializeObject(content);
            return jsonFormattedData.value;
        }
        public Category GetRandom()
        {
            var data = new Category();
            data.Joke = GetRandomJokes();
                return data;
        }

        
    }
 
}