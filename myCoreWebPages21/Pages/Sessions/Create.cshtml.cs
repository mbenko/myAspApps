using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using myAspData.Models;
using myCoreWebPages21.Models;

namespace myCoreWebPages21.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        private readonly myCoreWebPages21.Models.myCoreWebPages21Context _context;

        public CreateModel(myCoreWebPages21.Models.myCoreWebPages21Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Session.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}