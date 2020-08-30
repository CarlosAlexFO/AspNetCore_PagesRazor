using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilme.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesFilme.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilme.Data.RazorPagesFilmeContext _context;

        public IndexModel(RazorPagesFilme.Data.RazorPagesFilmeContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Generos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; }


        public async Task OnGetAsync()
        {
            var filmes = from m in _context.Filme
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                filmes = NewMethod(filmes);
            }

            Filme = await filmes.ToListAsync();
        }

        private IQueryable<Filme> NewMethod(IQueryable<Filme> filmes)
        {
            filmes = filmes.Where(s => s.Titulo.Contains(SearchString));
            return filmes;
        }
    }


}
