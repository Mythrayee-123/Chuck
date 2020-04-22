using ChuckJokes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckJokes.ViewModel
{
    public class HomeDetailViewModel
    {
        public Category Category { get; set; }
        public string pagetitle { get; set; }
        public string pageheader { get; set; }
       public Category Random { get; set; }
       [BindProperty(SupportsGet = true)]
        public Category SearchTerm{ get; set; }

    }
   
}
