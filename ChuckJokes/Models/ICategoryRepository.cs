using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckJokes.Models
{
   public interface ICategoryRepository
    {
        Category GetCategory(int Id);
        Category GetCategory(string category);
        Category GetRandom();
        Category GetJokes(string SearchTerm,string category);
     
        IEnumerable<Category> GetAllCategories();
      
    }
}
