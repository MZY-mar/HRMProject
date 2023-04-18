using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HRM.MVC.Controllers.Filters
{
    public class SomeFIlter : IActionFilter
    {

        private readonly ILogger<SomeFIlter> _logger;

        public SomeFIlter(ILogger<SomeFIlter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
           _logger.LogInformation("Action is being executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.Result is ViewResult viewResult){
                context.Result = new RedirectToActionResult("Index","Home", null);
            }
              _logger.LogInformation("Action is finished");
        }
    }
}