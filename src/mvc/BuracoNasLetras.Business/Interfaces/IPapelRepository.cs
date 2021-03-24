using BuracoNasLetras.Business.Models;
using System.Threading.Tasks;

namespace BuracoNasLetras.Business.Interfaces
{
    public interface IPapelRepository
    {
        Task Adicionar(Papel papel);
        Task<int> SaveChanges();
    }
}
