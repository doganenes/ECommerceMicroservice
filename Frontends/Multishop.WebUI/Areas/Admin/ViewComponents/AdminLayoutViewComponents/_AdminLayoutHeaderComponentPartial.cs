﻿using Microsoft.AspNetCore.Mvc;

namespace Multishop.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutHeaderComponentPartial : ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
