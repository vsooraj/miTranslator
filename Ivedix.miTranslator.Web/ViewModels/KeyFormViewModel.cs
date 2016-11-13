using System.Web;

namespace Ivedix.miTranslator.Web.ViewModels
{

    public class KeyFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string KeyTitle { get; set; }
        public string KeyDescription { get; set; }
        public decimal KeyPrice { get; set; }
        public int KeyCategory { get; set; }
    }
}