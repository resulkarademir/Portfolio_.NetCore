using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext _context =new MyPortfolioContext();
		public IActionResult Index()
		{
			var value=_context.ToDoLists.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			_context.ToDoLists.Add(toDoList);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{ 
			var value=_context.ToDoLists.Find(id);
			_context.ToDoLists.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = _context.ToDoLists.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			_context.ToDoLists.Update(toDoList);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ToDoListStatusFalse(int id)
		{
			var value = _context.ToDoLists.Find(id);
			value.Status=false;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
        public IActionResult ToDoListStatusTrue(int id)
        {
            var value = _context.ToDoLists.Find(id);
            value.Status = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
