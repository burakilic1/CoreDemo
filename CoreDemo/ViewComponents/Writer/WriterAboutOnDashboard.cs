using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterAboutOnDashboard : ViewComponent
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IViewComponentResult Invoke()
		{
			var values = wm.GetWriterById(1);
			return View(values);
		}
	}
}
