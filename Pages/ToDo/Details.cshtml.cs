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
    public class DetailsModel : PageModel
    {
        private readonly DotNetCoreSqlDb.Data.MyDatabaseContext _context;

        public DetailsModel(DotNetCoreSqlDb.Data.MyDatabaseContext context)
        {
            _context = context;
        }

        public Todo Todo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todo.FirstOrDefaultAsync(m => m.ID == id);

            if (Todo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
