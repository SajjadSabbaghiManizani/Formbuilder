using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.FormService;
using Domian.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Application.Dtos;


namespace Endpoints_API.Controllers
{

    [Authorize] 
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService _FormService;

        public FormController(IFormService FormService)
        {
            _FormService = FormService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Form>>> GetAllForms()
        {
            var Forms = await _FormService.GetAllFormsAsync();
 
            return Ok(Forms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Form>> GetForm(Guid  id)
        {
            var Form = await _FormService.GetFormDetailByIdAsync(id);
            if (Form == null)
            {
                return NotFound();
            }
            return Form;
        }

        [HttpPost]
        public async Task<ActionResult<Form>> CreateForm(NewFormDto item)
        {
            var Formid =await _FormService.AddFormAsync(item);
            return CreatedAtAction(nameof(GetForm), new { id = Formid }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateForm(Guid id, NewFormDto item)
        {
          var Form =  _FormService.GetFormByIdAsync(id);
            if(Form == null)
                return NotFound();

            await _FormService.UpdateFormAsync(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForm(Guid id)
        {
            var Form = await _FormService.GetFormByIdAsync(id);
            if (Form == null)
            {
                return NotFound();
            }

            await _FormService.DeleteFormAsync(id);
            return NoContent();
        }

        [HttpGet("HTML{id}")]
        public async Task<ActionResult<string>> GetHtmlForm(Guid id)
        {
            var Form = await _FormService.GetFormHtml(id);
            if (Form == null)
            {
                return NotFound();
            }
            return Form;
        }
    }
}

