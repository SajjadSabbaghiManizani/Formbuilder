using Application.Dtos;
using Domian.Entities;

namespace Application.FormService
{
    public interface IFormService
    {
        Task<Form> GetFormByIdAsync(Guid id);
        Task<Form> GetFormDetailByIdAsync(Guid id);
        Task<List<Form>> GetAllFormsAsync();
        Task<string> AddFormAsync(NewFormDto form);
        Task UpdateFormAsync(NewFormDto form);
        Task DeleteFormAsync(Guid id);
        Task<string> GetFormHtml(Guid id);
    }
}
