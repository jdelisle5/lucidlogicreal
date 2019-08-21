using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LucidLogic.Models
{
    public class Blog
    {
        public int Id {get; set;}
        public string Title {get; set;}

        public ICollection<Post> Posts {get; set;}
    }
}