using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    /**
     * Базовый репозиторий для работы с сущностями в БД
     */
    public class BaseRepository<TEntity> : IBaseRepository where TEntity : class
    {
        private readonly DbContext _context;
        private IQueryable<TEntity> Set { get; }

        public BaseRepository(DbContext context)
        {
            this._context = context;
            this.Set = _context.Set<TEntity>();
        }
        public IQueryable<TEntity> Query() => Set;
    }
}
