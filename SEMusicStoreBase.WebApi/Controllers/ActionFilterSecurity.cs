﻿//@CodeCopy
#if ACCOUNT_ON
using Microsoft.AspNetCore.Mvc.Filters;

namespace SEMusicStoreBase.WebApi.Controllers
{
    public class ActionFilterSecurity : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
#endif
