using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChuckJokes.Models;
using ChuckJokes.ViewModel;

namespace ChuckJokes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _CategoryRepository;

        public HomeController(ICategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }
                
        
       
          public ViewResult Index(string SearchTerm,string category)
       {

           HomeDetailViewModel homeDetailViewModel = new HomeDetailViewModel()
           {
               SearchTerm = _CategoryRepository.GetJokes(SearchTerm,category),

           };
           return View(homeDetailViewModel);
       }
        public ViewResult Categories()
        {
            var model = _CategoryRepository.GetAllCategories();
            return View(model);
        }
        public ViewResult Random()
        {
            HomeDetailViewModel homeDetailViewModel = new HomeDetailViewModel()
            {
                Random = _CategoryRepository.GetRandom()

            };
            return View(homeDetailViewModel);
        }
        public ViewResult Details(string category)
        {
            HomeDetailViewModel homeDetailViewModel = new HomeDetailViewModel()
            {
                Category = _CategoryRepository.GetCategory(category),
                pageheader = "ChuckNorris",
                pagetitle = "Catagories"
            };
            return View(homeDetailViewModel);
        }
    }
}
