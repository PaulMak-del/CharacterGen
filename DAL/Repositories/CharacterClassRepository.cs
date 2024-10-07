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
    public class CharacterClassRepository: BaseRepository<CharacterClass>
    {
        public CharacterClassRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
