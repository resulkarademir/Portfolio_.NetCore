using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.ViewComponents._LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext _context =new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount=_context.ToDoLists.Where(x=>x.Status==false).Count();
			var values =_context.ToDoLists.Where(x=>x.Status==false).ToList();
			return View(values);
		}
	}
}
