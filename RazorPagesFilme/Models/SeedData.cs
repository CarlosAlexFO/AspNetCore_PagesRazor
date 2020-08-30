#define Rating
#if Rating
#region snippet_1 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesFilme.Data;
using RazorPagesFilme.Models;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesFilmeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesFilmeContext>>()))
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
                        Titulo = "Quem vai ficar com Mary",
                        DataLancamento = DateTime.Parse("1989-2-12"),
                        Genero = "Comédia Romantica",
                        Preco = 7.99M,
                        Classificacao = "R"
                    },

                #endregion
                    new Filme
                    {
                        Titulo = "Caça Fantasma",
                        DataLancamento = DateTime.Parse("1984-3-13"),
                        Genero = "Comédia",
                        Preco = 8.99M,
                        Classificacao = "R"
                    },

                    new Filme
                    {
                        Titulo = "Caça Fantasma 2",
                        DataLancamento = DateTime.Parse("1986-2-23"),
                        Genero = "Comédia",
                        Preco = 9.99M,
                        Classificacao = "B"
                    },

                        new Filme
                        {
                            Titulo = "Guerra nas Estrelas",
                            DataLancamento = DateTime.Parse("1986-2-23"),
                            Genero = "Aventura",
                            Preco = 9.99M,
                             Classificacao = "B"
                        },

                    new Filme
                    {
                        Titulo = "Rio Bravo",
                        DataLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Velho Oeste",
                        Preco = 3.99M,
                         Classificacao = "NA"
                    },

                      new Filme
                      {
                          Titulo = "Sexto Sentido",
                          DataLancamento = DateTime.Parse("2015-4-15"),
                          Genero = "Terror",
                          Preco = 3.99M,
                          Classificacao = "B"
                      },

                        new Filme
                        {
                            Titulo = "Dois Tiras da Pesada",
                            DataLancamento = DateTime.Parse("2000-4-11"),
                            Genero = "Policial",
                            Preco = 3.99M,
                            Classificacao = "B"
                        },

                    new Filme
                    {
                    Titulo = "E o vento levou",
                        DataLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Drama",
                        Preco = 4.99M,
                         Classificacao = "B"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif