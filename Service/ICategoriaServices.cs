using Esercizio2.Entities;

namespace Esercizio2.Service
{
    public interface ICategoriaServices
    {
        Task<Categoria> GetCategoria(string id);
        Task CreateCategoria(Categoria product);
    }
}
