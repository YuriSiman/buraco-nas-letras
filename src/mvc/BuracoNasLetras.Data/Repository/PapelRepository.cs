using BuracoNasLetras.Business.Interfaces;
using BuracoNasLetras.Business.Models;
using BuracoNasLetras.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuracoNasLetras.Data.Repository
{
    public class PapelRepository : IPapelRepository
    {
        protected readonly MeuDbContext _dbContext;
        protected readonly DbSet<Papel> _dbSet;

        public PapelRepository(MeuDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Papel>();
        }

        public async Task<List<Papel>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Adicionar(Papel papel)
        {
            _dbSet.Add(papel);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
