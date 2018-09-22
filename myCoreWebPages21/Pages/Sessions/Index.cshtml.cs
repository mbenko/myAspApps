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
    public class IndexModel : PageModel
    {
        private readonly myCoreWebPages21.Models.myCoreWebPages21Context _context;

        public IndexModel(myCoreWebPages21.Models.myCoreWebPages21Context context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; }

        public async Task OnGetAsync()
        {
            Session = await _context.Session.ToListAsync();
        }
    }
}
