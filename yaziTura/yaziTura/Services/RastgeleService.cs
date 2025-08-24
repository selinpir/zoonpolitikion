using Taraf.Models;
using static MudBlazor.Colors;

namespace yaziTura.Services
{
    public class RastgeleService : IRastgeleService
    {

        private readonly Random rnd = new Random();
        public ParaTarafi At()
        {
            return (rnd.Next(0, 2) == 0) ? ParaTarafi.Yazi : ParaTarafi.Tura;
        }
    }
}


