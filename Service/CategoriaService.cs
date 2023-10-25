using Esercizio2.DataAccess;
using Esercizio2.Entities;
using MongoDB.Driver;

namespace Esercizio2.Service
{
    public class CategoriaService : ICategoriaServices
    {
        private readonly IMagazzinoContext _context;



        public CategoriaService(IMagazzinoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }




        public async Task CreateCategoria(Categoria product)
        {
           await _context.Categoria.InsertOneAsync(product);
        }

        public async Task<Categoria> GetCategoria(string id)
        {
            return await _context.Categoria.Find(c => c.CategoryId == id).FirstOrDefaultAsync();

        }
    }
}
