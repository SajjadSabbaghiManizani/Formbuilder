using Domian.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities
{
    public class FormElement :BaseEntity
    {
      
   
        [Display(Name = "Label")]
        public string ElementLabel { get; set; } = string.Empty;
        [Display(Name = "Type")]
        public ElementType ElementType { get; set; } 
        [Display(Name = "Value")]
        public string ElementValue { get; set; } = string.Empty;
        [Required]
        public Guid FormId { get; set; }
        public Form? FormData { get; set; }
    }
  



}
