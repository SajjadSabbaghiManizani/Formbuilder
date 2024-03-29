using Domian.Entities;
using Infrastructure.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FormRepository : Repository<Form>, IFormRepository
    {
        public FormRepository(ApplicationDbContext context) : base(context)
        {

        }

       
    }
}
