using movieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCommandCategoryHandler
    {
        public readonly MovieContext _context;
        public RemoveCommandCategoryHandler(MovieContext context)
        {  _context = context; }

        public async void Handler (RemoveCategoryCommand command)
        {
            var value = await _context.Movies.FindAsync(command.CategoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
