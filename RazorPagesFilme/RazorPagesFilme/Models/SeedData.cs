
#define Avaliacao
#if Avaliacao
#region snippet_1 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesFilme.Data;
using System;
using System.Linq;

namespace RazorPagesFilme.Models

{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesFilmeContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesFilmeContext>>()))
            {
                // Look for any movies.
                if (context.Filme.Any())
                {
                    return;   // DB has been seeded
                }

                #region snippet1
                context.Filme.AddRange(
                    new Filme
                    {
                        Titulo = "Um tira da pesada",
                        DataLancamento = DateTime.Parse("1989-2-12"),
                        Genero = "Policial",
                        Preco = 7.99M,
                       
                    },
                #endregion

                    new Filme
                    {
                        Titulo = "Conan, o bárbaro ",
                        DataLancamento = DateTime.Parse("1984-3-13"),
                        Genero = "Ação",
                        Preco = 8.99M,
                        
                    },

                    new Filme
                    {
                        Titulo = "Caça Fantasma ",
                        DataLancamento = DateTime.Parse("1986-2-23"),
                        Genero = "Comédia",
                        Preco = 9.99M,
                      
                    },

                     new Filme
                     {
                         Titulo = "Caça Fantasma 2",
                         DataLancamento = DateTime.Parse("1986-2-23"),
                         Genero = "Comédia",
                         Preco = 9.99M,
                      
                     },

                    new Filme
                    {
                        Titulo = "Rio Bravo",
                        DataLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Velho Oeste",
                        Preco = 3.99M,
                       
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif
