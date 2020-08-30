using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<Filme> Filme { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;

        public SelectList Generos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Filme
                                            orderby m.Genero
                                            select m.Genero;

            var filmes = from m in _context.Filme
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                filmes = filmes.Where(s => s.Titulo.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(FilmeGenero))
            {
                filmes = filmes.Where(x => x.Genero == FilmeGenero);
            }
            Generos = new SelectList(await genreQuery.Distinct().ToListAsync());
            Filme = await filmes.ToListAsync();
        }

        //public async Task OnGetAsync()
        //{
        //    var filmes = from m in _context.Filme
        //                 select m;
        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        filmes = filmes.Where(s => s.Titulo.Contains(SearchString));
        //    }

        //    Filme = await filmes.ToListAsync();
        //}

    }
}


