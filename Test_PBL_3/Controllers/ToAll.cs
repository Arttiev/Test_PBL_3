using Microsoft.AspNetCore.Mvc;
using Test_PBL_3.Data;

namespace Test_PBL_3.Controllers
{
	public class ToAll : Controller
	{
		private readonly AppDBContext _appDBContext;

		ToAll(AppDBContext appDBContext)
		{
			_appDBContext = appDBContext;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
