using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext _context =new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var value=_context.Messages.ToList();
			return View(value);
		}

		public IActionResult MessageChangeStatusTrue(int id) {
		
			var value=_context.Messages.Find(id);
			value.IsRead=true;
			_context.SaveChanges();
			return RedirectToAction("Inbox");


		}

		public IActionResult MessageChangeStatusFalse(int id)
		{
			var value = _context.Messages.Find(id);
			value.IsRead = false;
			_context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDelete(int id)
		{
			var value = _context.Messages.Find(id);
			_context.Messages.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var value=_context.Messages.Find(id);
			return View(value); 
		}
	}
}
