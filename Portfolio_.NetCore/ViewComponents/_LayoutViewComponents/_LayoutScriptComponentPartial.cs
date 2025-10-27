using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents._LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
