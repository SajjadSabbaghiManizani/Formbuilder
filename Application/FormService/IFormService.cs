using Application.Dtos;
using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormService
{
    public interface IFormService
    {
        Task<Form> GetFormByIdAsync(Guid id);
        Task<List<Form>> GetAllFormsAsync();
        Task<string> AddFormAsync(NewFormDto form);
        Task UpdateFormAsync(NewFormDto form);
        Task DeleteFormAsync(Guid id);
    }
}
