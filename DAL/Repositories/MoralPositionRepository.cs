using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MoralPositionRepository: BaseRepository<MoralPosition>
    {
        public MoralPositionRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
