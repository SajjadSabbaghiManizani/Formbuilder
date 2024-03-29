using Domian.Enums;
using System.Runtime.InteropServices;

namespace Domian.Entities
{
    public class Form : BaseEntity
    {
        public Form()
        {
            FormElements = new List<FormElement>();
        }
        public FormStyle Style { get; set; }
        public virtual ICollection<FormElement> FormElements { get; set; }
        public string Language { get; set; }

    }
}
