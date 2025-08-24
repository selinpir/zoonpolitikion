using Taraf.Models;
namespace yaziTura.Services
{
    public class RastgeleService : IRastgeleService
    {
        private readonly Random rnd = new Random();
        public ParaTarafi At()
        {
            // rnd.Next(0,2)  0 yazi veya 1 tura döndürür
            return (rnd.Next(0, 2) == 0) ? ParaTarafi.Yazi : ParaTarafi.Tura;
        }
    }
}


