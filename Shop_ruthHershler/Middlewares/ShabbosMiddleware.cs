using Microsoft.AspNetCore.Mvc;

namespace Shop.API.Middlewares
{
    public class ShabbosMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ShabbosMiddleware> _logger;

        public ShabbosMiddleware(RequestDelegate next, ILogger<ShabbosMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            var requestSeq = Guid.NewGuid().ToString();
            //_logger.LogInformation($"Request Starts {requestSeq}");
            //context.Items.Add("RequestSequence", requestSeq);

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.Headers.Add("Custom-Error-Message", "Requests cannot be processed on Saturdays");
                return;
            }

            await _next(context);

            //_logger.LogInformation($"Request Ends {requestSeq}");
        }
    }
        public static class ShabbosMiddlewareExtensions
    {
        public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShabbosMiddleware>();
        }
    }
}
