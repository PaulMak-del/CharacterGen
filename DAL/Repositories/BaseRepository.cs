using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<TEntity>
    {
        private IQueryable<TEntity> Set { get; }
        public IQueryable<TEntity> Query() => Set;
    }
}
