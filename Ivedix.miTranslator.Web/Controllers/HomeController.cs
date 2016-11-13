using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Ivedix.miTranslator.Model;
using Ivedix.miTranslator.Service;
using Ivedix.miTranslator.Web.ViewModels;

namespace Ivedix.miTranslator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IKeyService gadgetService;

        public HomeController(ICategoryService categoryService, IKeyService gadgetService)
        {
            this.categoryService = categoryService;
            this.gadgetService = gadgetService;
        }

        // GET: Home
        public ActionResult Index(string category = null)
        {
            IEnumerable<CategoryViewModel> viewModelKeys;
            IEnumerable<Category> categories;

            categories = categoryService.GetCategories(category);

            viewModelKeys = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(viewModelKeys);
        }
        public ActionResult Filter(string category, string keyName)
        {
            IEnumerable<KeyViewModel> viewModelKeys;
            IEnumerable<Key> keys;

            keys = gadgetService.GetCategoryKeys(category, keyName);

            viewModelKeys = Mapper.Map<IEnumerable<Key>, IEnumerable<KeyViewModel>>(keys);

            return View(viewModelKeys);
        }

        [HttpPost]
        public ActionResult Create(KeyFormViewModel newKey)
        {
            if (newKey != null && newKey.File != null)
            {
                var gadget = Mapper.Map<KeyFormViewModel, Key>(newKey);
                gadgetService.CreateKey(gadget);

                string gadgetPicture = System.IO.Path.GetFileName(newKey.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), gadgetPicture);
                newKey.File.SaveAs(path);

                gadgetService.SaveKey();
            }

            var category = categoryService.GetCategory(newKey.KeyCategory);
            return RedirectToAction("Index", new { category = category.Name });
        }
    }
}