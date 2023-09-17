﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transofast.Domain.Entities.Concrete;
using Transofast.Domain.IRepositories;
using Transofast.Infrastructure.DataAccess;

namespace Transofast.Infrastructure.Repository
{
    public class TransportRepository:BaseRepository<Transport>,ITransportRepository
    {
        public TransportRepository(TransofastDbContext transofastDb) : base(transofastDb) { }
    }
}
