using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities
{
    public class FormStyle : BaseEntity
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
        public Form Form { get; set; }
        public Guid FormId { get; set; }
    }
}
