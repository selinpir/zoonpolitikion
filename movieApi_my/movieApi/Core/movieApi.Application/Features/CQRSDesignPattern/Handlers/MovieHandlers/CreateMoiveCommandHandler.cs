using movieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMoiveCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMoiveCommandHandler(MovieContext context)
        { _context = context; }
        //________________________________________________________
        public async void Handle(CreateMovieCommand command)
        { 
            _context.Movies.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                Rating = command.Rating,
                ReleaseDate= command.ReleaseDate,
                Status= command.Status,
                Title= command.Title,   
            });
            await _context.SaveChangesAsync();
        }
        //________________________________________________________
    }
}
