using System.Collections.Generic;

namespace Ivedix.miTranslator.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<KeyViewModel> Keys { get; set; }
    }
}