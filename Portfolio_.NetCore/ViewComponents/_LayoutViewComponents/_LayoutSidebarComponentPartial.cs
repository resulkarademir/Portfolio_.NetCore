using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents._LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
