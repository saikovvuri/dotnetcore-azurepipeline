using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Data;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Pages.ToDo
{
    public class IndexModel : PageModel
    {
        private readonly DotNetCoreSqlDb.Data.MyDatabaseContext _context;

        public IndexModel(DotNetCoreSqlDb.Data.MyDatabaseContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; }

        public async Task OnGetAsync()
        {
            Todo = await _context.Todo.ToListAsync();
        }
    }
}
