﻿using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Concrete.Abstract;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Repositories.Concrete.EntityTypeRepository
{
    public class PublishingHouseRepository : BaseRepository<PublishingHouse>, IPublishingHouseRepository
    {
        public PublishingHouseRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
