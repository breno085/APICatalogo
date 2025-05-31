using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APICatalogo.Filters;

public class ApiLoggingFilter : IActionFilter
{
    private readonly ILogger<ApiLoggingFilter> _logger;

    public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Executa antes do método action dos controllers
        _logger.LogInformation("### Executando -> OnActionExecuting");
        _logger.LogInformation("###################################################");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"ModelState : {context.ModelState.IsValid}");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Executa depois da action
        _logger.LogInformation("### Executando -> OnActionExecuted");
        _logger.LogInformation("###################################################");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"Status Code : {context.HttpContext.Response.StatusCode}");
        _logger.LogInformation("###################################################");
    }
}