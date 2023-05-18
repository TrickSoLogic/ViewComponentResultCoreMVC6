﻿using Microsoft.AspNetCore.Mvc;
using ViewComponentResultCoreMVC6.Models;

namespace ViewComponentResultCoreMVC6.ViewComponents
{
  public class GridViewComponent : ViewComponent
  {
    public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
    {
      return View("Sample", grid); //invokes a partial view Views/Shared/Components/Grid/Sample.cshtml
    }
  }
}
