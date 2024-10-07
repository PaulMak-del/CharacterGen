using DAL.Entities;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RaceManager
    {
        private IServiceProvider serviceProvider;

        private RaceRepository _raceRepository;

        public RaceManager(IServiceProvider service)
        {
            serviceProvider = service;

            _raceRepository = serviceProvider.GetService<RaceRepository>();
            if (_raceRepository == null )
            {
                throw new Exception("ERROR: _raceRepository is null");
            }
        }

        public IList<Race> GetAllRaces()
        {
            Console.WriteLine(_raceRepository);
            Console.WriteLine(_raceRepository.Query());
            var tt = _raceRepository.Query().ToList();
            return tt;
        }

        public Race GetRaceById(string id)
        {
            return _raceRepository.Query().Where(el => el.Id.ToString() == id).FirstOrDefault();
        }
    }
}
