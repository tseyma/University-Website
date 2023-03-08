using Microsoft.AspNetCore.Mvc;

namespace duzce_uni.Components
{
    [ViewComponent]
    public class Kadro:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
