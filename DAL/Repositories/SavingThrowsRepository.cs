﻿using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SavingThrowsRepository: BaseRepository<SavingThrows>
    {
        public SavingThrowsRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
