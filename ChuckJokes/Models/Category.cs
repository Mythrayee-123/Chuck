using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace ChuckJokes.Models
{

    public class Category 
    {
        public int Id { get; set; }
        public string Items { get; set; }
        public string Joke { get; set; }
       

    }
}
