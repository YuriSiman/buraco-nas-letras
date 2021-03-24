using BuracoNasLetras.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuracoNasLetras.Business.Interfaces
{
    public interface IPapelRepository
    {
        Task Adicionar(Papel papel);
        Task<List<Papel>> ObterTodos();
        Task<int> SaveChanges();
    }
}
