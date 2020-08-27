using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilme.Data;
using RazorPagesFilme.Models;

namespace RazorPagesFilme.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilme.Data.RazorPagesFilmeContext _context;

        public IndexModel(RazorPagesFilme.Data.RazorPagesFilmeContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}
