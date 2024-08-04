using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNovBarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
