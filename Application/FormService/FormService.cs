using Application.Dtos;
using Domian.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormService
{
    public class FormService : IFormService
    {
        private readonly IFormRepository _formRepository;

        public FormService(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

      

        public async Task<List<Form>> GetAllFormsAsync()
        {
            return await _formRepository.GetAllAsync();
        }

        public async Task<string> AddFormAsync(NewFormDto form)
        {
            var newFormStyle = new FormStyle
            {
                AlignItems = form.Style.AlignItems,
                Color = form.Style.Color,
                Direction = form.Style.Direction,
                BackgroundColor = form.Style.BackgroundColor,
                FlexWrap = form.Style.FlexWrap,
                Height = form.Style.Height,
                Width = form.Style.Width,
                Justify = form.Style.Justify,
                MarginBottom = form.Style.MarginBottom,
                MarginLeft = form.Style.MarginLeft,
                MarginRight = form.Style.MarginRight,
                MarginTop = form.Style.MarginTop,
            };
        
            var newFormElement = new List<FormElement>();
            foreach (var FormElement in form.FormElements)
            {
                var newElement = new FormElement();
                newElement.ElementValue = FormElement.ElementValue;
                newElement.ElementType = FormElement.ElementType;  
                newElement.ElementLabel = FormElement.ElementLabel;
                newFormElement.Add(newElement);
            }
            var newRequest = new Form
            {
                Language = form.Language.ToString(),
                Style = newFormStyle,
                FormElements = newFormElement,

            };
            await _formRepository.AddAsync(newRequest);
            return newFormStyle.Id.ToString();
        }

        public async Task UpdateFormAsync(NewFormDto form)
        {
            var newFormStyle = new FormStyle
            {
                AlignItems = form.Style.AlignItems,
                Color = form.Style.Color,
                Direction = form.Style.Direction,
                BackgroundColor = form.Style.BackgroundColor,
                FlexWrap = form.Style.FlexWrap,
                Height = form.Style.Height,
                Width = form.Style.Width,
                Justify = form.Style.Justify,
                MarginBottom = form.Style.MarginBottom,
                MarginLeft = form.Style.MarginLeft,
                MarginRight = form.Style.MarginRight,
                MarginTop = form.Style.MarginTop,
            };
            var newFormElement = new List<FormElement>();
            foreach (var FormElement in form.FormElements)
            {
                var newElement = new FormElement();
                newElement.ElementValue = FormElement.ElementValue;
                newElement.ElementType = FormElement.ElementType;
                newElement.ElementLabel = FormElement.ElementLabel;
                newFormElement.Add(newElement);
            }
            var newRequest = new Form
            {
                Language = form.Language.ToString(),
                Style = newFormStyle,
                FormElements = newFormElement,

            };

            await _formRepository.UpdateAsync(newRequest);
        }

        public async Task DeleteFormAsync(Guid id)
        {
            await _formRepository.DeleteAsync(id);
        }

        public async Task<Form> GetFormByIdAsync(Guid id)
        {
           return await _formRepository.GetByIdAsync(id);
        }

        public Task<Form> GetFormDetailByIdAsync(Guid id)
        {
            return _formRepository.GetByIdFormAsync(id);
        }
    }

}
