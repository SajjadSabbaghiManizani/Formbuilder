﻿using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface  IFormRepository : IRepository<Form>
    {
            Task<Form> GetByIdFormAsync(Guid id);
    }
}
