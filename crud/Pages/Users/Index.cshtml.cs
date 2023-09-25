using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud.Data;
using crud.model;

namespace crud.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly crud.Data.crudContext _context;

        public IndexModel(crud.Data.crudContext context)
        {
            _context = context;
        }

        public IList<user> user { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.user != null)
            {
                user = await _context.user.ToListAsync();
            }
        }
    }
}
