using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LucidLogic.Models;

namespace LucidLogic.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private readonly LucidLogic.Models.BlogContext _context;

        public IndexModel(LucidLogic.Models.BlogContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}
