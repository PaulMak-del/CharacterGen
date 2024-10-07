using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class BackgroundRepository : BaseRepository<Background>
    {
        BackgroundRepository(ApplicationContext context) : base(context) { }
    }
}