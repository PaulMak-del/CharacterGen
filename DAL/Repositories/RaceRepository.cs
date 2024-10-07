using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    /**
    Репозиторий для работы с сущностью "Раса"
     */
    public class RaceRepository : BaseRepository<Race> {
        public RaceRepository(ApplicationContext context) : base(context) { }
    }
}
