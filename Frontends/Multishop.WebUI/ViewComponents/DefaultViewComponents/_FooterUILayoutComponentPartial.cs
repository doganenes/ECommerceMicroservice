﻿using Microsoft.AspNetCore.Mvc;

namespace Multishop.WebUI.ViewComponents.DefaultViewComponents
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
