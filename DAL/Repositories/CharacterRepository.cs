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
    public class CharacterRepository : BaseRepository<Character> 
    {
        public CharacterRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
