using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myAspData.Models;
using myCoreWebPages21.Models;

namespace myCoreWebPages21.Pages.Sessions
{
    public class DetailsModel : PageModel
    {
        private readonly myCoreWebPages21.Models.myCoreWebPages21Context _context;

        public DetailsModel(myCoreWebPages21.Models.myCoreWebPages21Context context)
        {
            _context = context;
        }

        public Session Session { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Session = await _context.Session.FirstOrDefaultAsync(m => m.Id == id);

            if (Session == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
