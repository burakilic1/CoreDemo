using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddCommnet()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog()
		{
			return PartialView();
		}
	}
}
