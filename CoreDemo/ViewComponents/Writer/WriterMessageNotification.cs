using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager mm2 = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            ViewBag.v1 = c.Message2s.Where(y => y.ReceiverID == 1).Count(x => x.MessageStatus == true).ToString();
            //Statusu true ve  alıcının siz olduğu mesajlar
            int id = 1;
            var values = mm2.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
