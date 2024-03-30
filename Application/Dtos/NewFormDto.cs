using Domian.Entities;
using Domian.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public record NewFormDto
    {
        public FormStyleDTO Style { get; set; }
        public  ICollection<FormElementDTO> FormElements { get; set; }
        public string Language { get; set; }

    }
    public record FormStyleDTO 
    {
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Color { get; set; }
        public string? BackgroundColor { get; set; }
        public int? MarginTop { get; set; }
        public int? MarginRight { get; set; }
        public int? MarginBottom { get; set; }
        public int? MarginLeft { get; set; }
        public string? AlignItems { get; set; }
        public string? Justify { get; set; }
        public string? FlexWrap { get; set; }
        public string? Direction { get; set; }
    }
    public record FormElementDTO 
    {

     
        public string ElementLabel { get; set; } = string.Empty;
        [Display(Name = "Type")]
        public ElementType ElementType { get; set; }
        [Display(Name = "Value")]
        public string ElementValue { get; set; } = string.Empty;
    }
}
