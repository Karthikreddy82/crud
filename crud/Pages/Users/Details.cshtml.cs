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
    public class DetailsModel : PageModel
    {
        private readonly crud.Data.crudContext _context;

        public DetailsModel(crud.Data.crudContext context)
        {
            _context = context;
        }

      public user user { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.user == null)
            {
                return NotFound();
            }

            var user = await _context.user.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                user = user;
            }
            return Page();
        }
    }
}
