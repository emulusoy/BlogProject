using BlogProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace BlogProject.PresentationLayer.ViewComponents
{
    public class _HeaderDefaultComponentPartial : ViewComponent
    {
       
   

        public IViewComponentResult Invoke()
        {
     
            return View();
        }
    }
}
