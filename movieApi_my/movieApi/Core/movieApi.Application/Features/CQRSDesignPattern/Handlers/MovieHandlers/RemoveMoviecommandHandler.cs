using movieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMoviecommandHandler
    {
        private readonly MovieContext _context;
        public RemoveMoviecommandHandler(MovieContext context) { _context = context; }
        public async void Handle(RemoveMovieCommand command)
        {
            var value=await _context.Movies.FindAsync(command.MovieId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
