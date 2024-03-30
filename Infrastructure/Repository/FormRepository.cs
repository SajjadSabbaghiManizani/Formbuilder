using Domian.Entities;
using Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class FormRepository : Repository<Form>, IFormRepository
    {
        private readonly ApplicationDbContext _context;
        public FormRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Form> GetByIdFormAsync(Guid id)
        {
            return await _context.Set<Form>()
                              .Include(x => x.FormElements)
                              .Include(x => x.Style)
                              .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
